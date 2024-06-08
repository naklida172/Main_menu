using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_menu
{
    public partial class Profile_settings : Form
    {
        string current_item="none";

        public Profile_settings()
        {
            InitializeComponent();
        }

        public void AllButtons(bool a) 
        {
            btnChangeEmail.Visible = a;
            btnChangePassword.Visible = a;
            btnChangeUsername.Visible = a;
            btnCancel.Visible = a;
            btnChangePhone.Visible = a;
            btnChangeAddress.Visible = a;
            btnSave.Visible = !a;
            lblQuestion.Visible = a;
            lblNewInfo.Visible = !a;
            lblPassword.Visible = !a;
            txtNewInfo.Visible = !a;
            txtPassword.Visible = !a;
            btnCancelSave.Visible = !a;
        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            AllButtons(false);
            current_item = "[Password]";
        }

        private void txtNewInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelSave_Click(object sender, EventArgs e)
        {
            current_item = "no";
            AllButtons(true);
        }

        private void btnChangePhone_Click(object sender, EventArgs e)
        {
            AllButtons(false);
            current_item = "[Phone]";
        }

        private void btnChangeAddress_Click(object sender, EventArgs e)
        {
            AllButtons(false);
            current_item = "[Address]";
        }

        private void btnChangeUsername_Click(object sender, EventArgs e)
        {
            AllButtons(false);
            current_item = "[Username]";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblQuestion.Text = ( MainMenu.current_user.Change(txtPassword.Text,txtNewInfo.Text,current_item));
            txtNewInfo.Text = (null);
            txtPassword.Text = (null);
            AllButtons(true);
        }
    }
}
