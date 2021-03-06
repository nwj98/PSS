using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS
{
    public partial class Form1 : Form
    {
        MainPage main = new MainPage();

        public Form1()
        {
            InitializeComponent();

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if(txtUser.Text == "ID입력")
            {
                txtUser.Text = "";
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if(txtUser.Text == "")
            {
                txtUser.Text = "ID입력";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if(txtPassword.Text == "PW입력")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if(txtPassword.Text == "")
            {
                txtPassword.Text = "PW입력";
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin@company.com")
            {
                if (txtPassword.Text == "1234")
                {
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("비밀번호를 다시 입력하시오","Password error", 
                        MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                    txtUser.Text = "ID입력";
                    txtPassword.Text = "PW입력";
                }
            }
            else
            {
                MessageBox.Show("아이디를 다시 입력하시오", "ID error",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtUser.Text = "ID입력";
                txtPassword.Text = "PW입력";
            }
            //this.Hide();
            //main.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
