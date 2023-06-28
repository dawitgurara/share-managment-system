using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SHM
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (clUser.ChangePassword(clMain.User.UserID, this.currentPasswordTextBox.Text, this.newPasswordTextBox.Text, this.confirmNewPasswordTextBox.Text))
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        
    }
}
