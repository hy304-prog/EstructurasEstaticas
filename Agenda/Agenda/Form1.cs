using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            var input = txtInput.Text ?? string.Empty;

            if (string.IsNullOrEmpty(input))
            {
                txtOutput.Text = string.Empty;
                return;
            }

            // Convert each character to its ASCII code, add 3, and join with spaces
            var codes = input.Select(c => ((int)c) + 3);
            txtOutput.Text = string.Join(" ", codes);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = string.Empty;
            txtOutput.Text = string.Empty;
            txtInput.Focus();
        }
    }
}
