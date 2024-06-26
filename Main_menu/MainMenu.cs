﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_menu
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        class User
        {
            private string username;
            private string email;
            private string password;
            private string role;
            public User(string username, string email, string password, string role)
            {
                this.username = username;
                this.email = email;
                this.password = password;
                this.role = role;
            }

            public bool Check_password(string password)
            {
                if(this.password==password)
                    return true;
                else return false;
            }
            public bool Check_login(string logindata)
            {
                if (logindata == this.email || logindata == this.username) return true;
                else return false;
            }
            public string RolePlay()
            { return this.role; }
        }


        List<User> Users = new List<User>
        {
            new User("john_doe", "john@example.com", "password123", "User"),
            new User("guest", "guest@example.com", "guestpass", "Guest"),
            new User("manager123", "manager@example.com", "securepwd", "Manager"),
            new User("dev_guy", "dev@example.com", "devpassword", "Developer"),
            new User("support_agent", "support@example.com", "helpme", "Support"),
            new User("sales_rep", "sales@example.com", "sales123", "Sales"),
            new User("marketing_guru", "marketing@example.com", "promo123", "Marketing"),
            new User("cs_agent", "cs@example.com", "customerservice", "Customer Service"),
            new User("testuser", "test@example.com", "test123", "Test")
        };





        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Users.Count; i++)
                {
                    if (Users[i].Check_login(txtbxLogin.Text))
                    {
                        if (Users[i].Check_password(txtbxPassword.Text))
                        {
                            Manager obj1 = new Manager();
                            obj1.ShowDialog();
                        }
                        else
                        {
                            lblTest.Text = "Wrong password";
                        }
                    }
                }

            } catch { lblTest.Text = "Error"; }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void lblTest_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminView form1 = new AdminView();

            form1.ShowDialog();
        }
    }
}
