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
    public partial class FormMasterPassword : Form
    {
        public FormMasterPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Bitte ein Passwort eingeben!", "PWGen");
                return;
            }
            this.Hide();
            FormPasswordManager fpm = new FormPasswordManager(txtPassword.Text);
            fpm.Show(this.Owner);
            fpm.BringToFront();
        }
    }
}
