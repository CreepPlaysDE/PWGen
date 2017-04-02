namespace PWGen
{
    partial class FormPasswordManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPasswordManager));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeViewStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenWebsite = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUsername = new System.Windows.Forms.Button();
            this.btnCopyPassword = new System.Windows.Forms.Button();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.treeViewStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.treeViewStrip;
            this.treeView1.Location = new System.Drawing.Point(14, 13);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(178, 412);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // treeViewStrip
            // 
            this.treeViewStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hinzufügenToolStripMenuItem,
            this.löschenToolStripMenuItem});
            this.treeViewStrip.Name = "treeViewStrip";
            this.treeViewStrip.Size = new System.Drawing.Size(137, 48);
            // 
            // hinzufügenToolStripMenuItem
            // 
            this.hinzufügenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategorieToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.hinzufügenToolStripMenuItem.Name = "hinzufügenToolStripMenuItem";
            this.hinzufügenToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.hinzufügenToolStripMenuItem.Text = "Hinzufügen";
            // 
            // kategorieToolStripMenuItem
            // 
            this.kategorieToolStripMenuItem.Name = "kategorieToolStripMenuItem";
            this.kategorieToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.kategorieToolStripMenuItem.Text = "Kategorie";
            this.kategorieToolStripMenuItem.Click += new System.EventHandler(this.kategorieToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.löschenToolStripMenuItem.Text = "Löschen";
            this.löschenToolStripMenuItem.Click += new System.EventHandler(this.löschenToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnOpenWebsite);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnUsername);
            this.groupBox1.Controls.Add(this.btnCopyPassword);
            this.groupBox1.Controls.Add(this.btnShowPassword);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtWebsite);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(198, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 412);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            this.groupBox1.Visible = false;
            // 
            // btnOpenWebsite
            // 
            this.btnOpenWebsite.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpenWebsite.Location = new System.Drawing.Point(210, 383);
            this.btnOpenWebsite.Name = "btnOpenWebsite";
            this.btnOpenWebsite.Size = new System.Drawing.Size(118, 23);
            this.btnOpenWebsite.TabIndex = 10;
            this.btnOpenWebsite.Text = "Website öffnen";
            this.btnOpenWebsite.UseVisualStyleBackColor = true;
            this.btnOpenWebsite.Click += new System.EventHandler(this.btnOpenWebsite_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(334, 383);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUsername
            // 
            this.btnUsername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUsername.Location = new System.Drawing.Point(320, 71);
            this.btnUsername.Name = "btnUsername";
            this.btnUsername.Size = new System.Drawing.Size(89, 23);
            this.btnUsername.TabIndex = 8;
            this.btnUsername.Text = "Kopieren";
            this.btnUsername.UseVisualStyleBackColor = true;
            this.btnUsername.Click += new System.EventHandler(this.btnUsername_Click);
            // 
            // btnCopyPassword
            // 
            this.btnCopyPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCopyPassword.Location = new System.Drawing.Point(225, 126);
            this.btnCopyPassword.Name = "btnCopyPassword";
            this.btnCopyPassword.Size = new System.Drawing.Size(89, 23);
            this.btnCopyPassword.TabIndex = 7;
            this.btnCopyPassword.Text = "Kopieren";
            this.btnCopyPassword.UseVisualStyleBackColor = true;
            this.btnCopyPassword.Click += new System.EventHandler(this.btnCopyPassword_Click);
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnShowPassword.Location = new System.Drawing.Point(320, 126);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(89, 23);
            this.btnShowPassword.TabIndex = 6;
            this.btnShowPassword.Text = "Anzeigen";
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(93, 100);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(316, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Passwort:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(93, 45);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(316, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Benutzername:";
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(114, 17);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(295, 20);
            this.txtWebsite.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Website/Programm:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(198, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 412);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 39);
            this.label4.TabIndex = 0;
            this.label4.Text = "Willkommen im Passwort-Manager!\r\n\r\nLinks kann man mit Rechtsklick Kategorien und " +
    "Logins hinzufügen.";
            // 
            // FormPasswordManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(625, 437);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPasswordManager";
            this.Text = "Passwort-Manager";
            this.Load += new System.EventHandler(this.FormPasswordManager_Load);
            this.treeViewStrip.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip treeViewStrip;
        private System.Windows.Forms.ToolStripMenuItem hinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpenWebsite;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUsername;
        private System.Windows.Forms.Button btnCopyPassword;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
    }
}