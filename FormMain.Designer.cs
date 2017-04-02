namespace PWGen
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnKeys = new System.Windows.Forms.Button();
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudLength = new System.Windows.Forms.NumericUpDown();
            this.chkUmlauts = new System.Windows.Forms.CheckBox();
            this.chkLetters = new System.Windows.Forms.CheckBox();
            this.chkNumbers = new System.Windows.Forms.CheckBox();
            this.chkSpecial = new System.Windows.Forms.CheckBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtPassword = new PWGen.TransparentTextBox();
            this.panelMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Controls.Add(this.btnKeys);
            this.panelMain.Controls.Add(this.btnAdvanced);
            this.panelMain.Controls.Add(this.groupBox1);
            this.panelMain.Controls.Add(this.btnGenerate);
            this.panelMain.Controls.Add(this.txtPassword);
            this.panelMain.Location = new System.Drawing.Point(13, 13);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(259, 304);
            this.panelMain.TabIndex = 0;
            // 
            // btnKeys
            // 
            this.btnKeys.Location = new System.Drawing.Point(4, 129);
            this.btnKeys.Name = "btnKeys";
            this.btnKeys.Size = new System.Drawing.Size(46, 23);
            this.btnKeys.TabIndex = 4;
            this.btnKeys.Text = "Keys";
            this.btnKeys.UseVisualStyleBackColor = true;
            this.btnKeys.Click += new System.EventHandler(this.btnKeys_Click);
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.Location = new System.Drawing.Point(50, 129);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(75, 23);
            this.btnAdvanced.TabIndex = 1;
            this.btnAdvanced.Text = "Erweitert";
            this.btnAdvanced.UseVisualStyleBackColor = true;
            this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudLength);
            this.groupBox1.Controls.Add(this.chkUmlauts);
            this.groupBox1.Controls.Add(this.chkLetters);
            this.groupBox1.Controls.Add(this.chkNumbers);
            this.groupBox1.Controls.Add(this.chkSpecial);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(4, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 140);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Erweiterte Einstellungen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Länge:";
            // 
            // nudLength
            // 
            this.nudLength.Location = new System.Drawing.Point(55, 111);
            this.nudLength.Name = "nudLength";
            this.nudLength.Size = new System.Drawing.Size(120, 20);
            this.nudLength.TabIndex = 4;
            this.nudLength.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // chkUmlauts
            // 
            this.chkUmlauts.AutoSize = true;
            this.chkUmlauts.Location = new System.Drawing.Point(6, 88);
            this.chkUmlauts.Name = "chkUmlauts";
            this.chkUmlauts.Size = new System.Drawing.Size(65, 17);
            this.chkUmlauts.TabIndex = 5;
            this.chkUmlauts.Text = "Umlaute";
            this.chkUmlauts.UseVisualStyleBackColor = true;
            // 
            // chkLetters
            // 
            this.chkLetters.AutoSize = true;
            this.chkLetters.Checked = true;
            this.chkLetters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLetters.Location = new System.Drawing.Point(6, 19);
            this.chkLetters.Name = "chkLetters";
            this.chkLetters.Size = new System.Drawing.Size(83, 17);
            this.chkLetters.TabIndex = 0;
            this.chkLetters.Text = "Buchstaben";
            this.chkLetters.UseVisualStyleBackColor = true;
            // 
            // chkNumbers
            // 
            this.chkNumbers.AutoSize = true;
            this.chkNumbers.Checked = true;
            this.chkNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNumbers.Location = new System.Drawing.Point(6, 42);
            this.chkNumbers.Name = "chkNumbers";
            this.chkNumbers.Size = new System.Drawing.Size(59, 17);
            this.chkNumbers.TabIndex = 1;
            this.chkNumbers.Text = "Zahlen";
            this.chkNumbers.UseVisualStyleBackColor = true;
            this.chkNumbers.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkSpecial
            // 
            this.chkSpecial.AutoSize = true;
            this.chkSpecial.Checked = true;
            this.chkSpecial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSpecial.Location = new System.Drawing.Point(6, 65);
            this.chkSpecial.Name = "chkSpecial";
            this.chkSpecial.Size = new System.Drawing.Size(97, 17);
            this.chkSpecial.TabIndex = 2;
            this.chkSpecial.Text = "Sonderzeichen";
            this.chkSpecial.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(127, 129);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(129, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Neu generieren";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(252, 108);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.SelectedIndexChanged += new System.EventHandler(this.txtPassword_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(286, 173);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "PWGen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnAdvanced;
        private System.Windows.Forms.CheckBox chkNumbers;
        private System.Windows.Forms.CheckBox chkLetters;
        private System.Windows.Forms.Button btnGenerate;
        private TransparentTextBox txtPassword;
        private System.Windows.Forms.NumericUpDown nudLength;
        private System.Windows.Forms.CheckBox chkSpecial;
        private System.Windows.Forms.CheckBox chkUmlauts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKeys;

    }
}

