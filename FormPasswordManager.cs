using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security;
using System.IO;
using System.Diagnostics;
using Newtonsoft.Json;
using PWGen.API;
using System.Threading;

namespace PWGen
{
    public partial class FormPasswordManager : Form
    {
        private string password = "";

        private List<Category> categories = new List<Category>();

        private Category currentCategory;
        private Login currentLogin;

        public FormPasswordManager(string password)
        {
            InitializeComponent();
            this.password = password;
            this.Shown += (s,e) =>
            {
                this.BringToFront();
                this.CenterToScreen();
            };
        }

        private void FormPasswordManager_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Path.Combine(Environment.CurrentDirectory, "data.db")))
            {
                File.Create(Path.Combine(Environment.CurrentDirectory, "data.db"));
            }
            else
            {
                if (File.ReadAllBytes(Path.Combine(Environment.CurrentDirectory, "data.db")).Length != 0)
                {
                    try
                    {
                        string json = Crypto.DecryptStringAES(File.ReadAllBytes(Path.Combine(Environment.CurrentDirectory, "data.db")), this.password);
                        categories = JsonConvert.DeserializeObject<List<Category>>(json);
                        UpdateTreeView();
                    }
                    catch
                    {
                        MessageBox.Show("Falsches Passwort!");
                        this.Close();
                    }
                }
            }
        }

        private void UpdateTreeView()
        {
            treeView1.Nodes.Clear();
            foreach (Category category in categories)
            {
                TreeNode tn = new TreeNode(category.Name);
                foreach (Login login in category.Logins)
                {
                    TreeNode tnn = new TreeNode(login.Name);
                    tn.Nodes.Add(tnn);
                }
                treeView1.Nodes.Add(tn);
            }
            treeView1.ExpandAll();
        }

        private void kategorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputForm iform = new InputForm("Gebe einen Namen für die Kategorie ein:");
            iform.InputRaised += new InputForm.InputRaisedEventHandler((input) =>
            {
                categories.Add(new Category() { Name = input, Logins = new List<Login>() });
                UpdateTreeView();
            });
            iform.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Parent != null) return;
            InputForm iform = new InputForm("Gebe einen Namen für den Login ein:");
            iform.InputRaised += new InputForm.InputRaisedEventHandler((input) =>
            {
                for (int i = 0; i < categories.Count; i++)
                {
                    if (categories[i].Name == treeView1.SelectedNode.Text)
                    {
                        categories[i].Logins.Add(new Login() { Name = input });
                        UpdateTreeView();
                        break;
                    }
                }
            });
            iform.ShowDialog();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent == null || e.Node == null)
            {
                txtWebsite.Text = "";
                txtUsername.Text = "";
                txtPassword.Text = "";
                groupBox1.Visible = false;
                groupBox2.Visible = true;
            }
            else if (e.Node.Parent != null)
            {
                Category cat = categories.First((c) => c.Name == e.Node.Parent.Text);
                Login log = cat.Logins.First((l) => l.Name == e.Node.Text);
                if (cat != null && log != null)
                {
                    currentCategory = cat;
                    currentLogin = log;

                    groupBox1.Text = "Details für " + currentCategory.Name + " - " + currentLogin.Name;

                    txtWebsite.Text = currentLogin.Url;
                    txtUsername.Text = currentLogin.Username;
                    txtPassword.Text = currentLogin.Password;
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                }
            }
        }

        private void btnOpenWebsite_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(txtWebsite.Text);
            }
            catch
            {
                MessageBox.Show("Dieser Pfad existiert nicht.", "PWGen - Passwort-Manager", MessageBoxButtons.OK);
            }
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = (txtPassword.PasswordChar == '*') ? '\0' : '*';
            btnShowPassword.Text = (txtPassword.PasswordChar == '*') ? "Anzeigen" : "Verstecken";
        }

        private void btnCopyPassword_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPassword.Text);
        }

        private void btnUsername_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtUsername.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (currentCategory == null || currentLogin == null) return;
            for (int i = 0; i < categories.Count; i++)
            {
                if(categories[i].Name == currentCategory.Name) 
                {
                    for (int x = 0; x < categories[i].Logins.Count; x++)
                    {
                        if (categories[i].Logins[x].Name == currentLogin.Name)
                        {
                            categories[i].Logins[x].Url = txtWebsite.Text;
                            categories[i].Logins[x].Username = txtUsername.Text;
                            categories[i].Logins[x].Password = txtPassword.Text;
                            UpdateTreeView();
                            new Thread(() => {
                                this.BeginInvoke(new Action(() => this.Text = "Passwort-Manager - Speichern ..."));
                                File.WriteAllBytes(Path.Combine(Environment.CurrentDirectory, "data.db"), Crypto.EncryptStringAES(JsonConvert.SerializeObject(categories), this.password));
                                this.BeginInvoke(new Action(() => this.Text = "Passwort-Manager"));
                            }).Start();
                            return;
                        }
                    }
                    return;
                }
            }
        }

        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Parent == null)
            {
                // Category
                if (MessageBox.Show("Wirklich löschen?", "PW-Gen - Passwort-Manager", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    for (int i = 0; i < categories.Count; i++)
                    {
                        if (categories[i].Name == treeView1.SelectedNode.Text)
                        {
                            categories.RemoveAt(i);
                            UpdateTreeView();
                            new Thread(() =>
                            {
                                this.BeginInvoke(new Action(() => this.Text = "Passwort-Manager - Speichern ..."));
                                File.WriteAllBytes(Path.Combine(Environment.CurrentDirectory, "data.db"), Crypto.EncryptStringAES(JsonConvert.SerializeObject(categories), this.password));
                                this.BeginInvoke(new Action(() => this.Text = "Passwort-Manager"));
                            }).Start();
                            return;
                        }
                    }
                }
            }
            else
            {
                // Login
                if (MessageBox.Show("Wirklich löschen?", "PW-Gen - Passwort-Manager", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    for (int i = 0; i < categories.Count; i++)
                    {
                        for (int x = 0; x < categories[i].Logins.Count; x++)
                        {
                            if (categories[i].Logins[x].Name == treeView1.SelectedNode.Text)
                            {
                                categories[i].Logins.RemoveAt(x);
                                UpdateTreeView();
                                new Thread(() =>
                                {
                                    this.BeginInvoke(new Action(() => this.Text = "Passwort-Manager - Speichern ..."));
                                    File.WriteAllBytes(Path.Combine(Environment.CurrentDirectory, "data.db"), Crypto.EncryptStringAES(JsonConvert.SerializeObject(categories), this.password));
                                    this.BeginInvoke(new Action(() => this.Text = "Passwort-Manager"));
                                }).Start();
                                return;
                            }

                        }
                    }
                }
            }
        }
    }
}
