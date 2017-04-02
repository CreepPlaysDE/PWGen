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
    public partial class InputForm : Form
    {
        public delegate void InputRaisedEventHandler(string input);
        public event InputRaisedEventHandler InputRaised;

        public InputForm(string text)
        {
            InitializeComponent();
            this.lblText.Text = text;
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            this.txtInput.Clear();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (InputRaised != null)
                InputRaised(txtInput.Text);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
