using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PWGen
{
    public partial class FormMain : Form
    {
        string chars = "abcdefghijklmnopqrstuvwxyz";
        string numbers = "1234567890";
        string umlauts = "äöü";
        string special = "><|,;.:-_#'+*~°^!\"§$%&/()=?`´";

        Random random = new Random();

        Boolean advanced = false;

        public FormMain()
        {
            InitializeComponent();
            string c = chars + numbers + special;
            txtPassword.Items.Clear();
            for (int i = 30; i > 9; i -= 4)
            {
                txtPassword.Items.Add(GetPassword(c, i));
            }
            this.Shown += (s, e) =>
            {
                this.BringToFront();
                this.CenterToScreen();
            };
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string GetPassword(string chars, int length)
        {
            string pw = "";
            int bounds = chars.Length;
            for (int i = 0; i < length; i++)
            {
                char c = chars.ToCharArray()[random.Next(bounds)];
                if (pw != "")
                {
                    while (c == pw.ToCharArray()[pw.Length - 1])
                    {
                        c = chars.ToCharArray()[random.Next(bounds)];
                    }
                }
                pw += c;
            }
            return pw;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (advanced)
            {
                string c = "";
                if (chkLetters.Checked) c += chars;
                if (chkNumbers.Checked) c += numbers;
                if (chkSpecial.Checked) c += special;
                if (chkUmlauts.Checked) c += umlauts;
                txtPassword.Items.Clear();
                int length = (int)nudLength.Value;
                for (int i = 0; i < 7; i++)
                {
                    txtPassword.Items.Add(GetPassword(c, length));
                }
            }
            else
            {
                string c = chars + numbers + special;
                txtPassword.Items.Clear();
                for (int i = 30; i > 9; i -= 4)
                {
                    txtPassword.Items.Add(GetPassword(c, i));
                }
            }
        }

        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            advanced = !advanced;
            groupBox1.Visible = advanced;
            if (advanced)
            {
                btnAdvanced.Text = "Einfach";
                this.Height = 365;
            }
            else
            {
                btnAdvanced.Text = "Erweitert";
                this.Height = 212;
            }
        }

        private void txtPassword_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.SetText((string)txtPassword.SelectedItem);
        }

        private void btnKeys_Click(object sender, EventArgs e)
        {
            new FormMasterPassword().ShowDialog();
        }

    }
}
