using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWLogin
{
    public partial class Form1 : Form
    {
        SingleDB sdb = SingleDB.getInstance();

        public Form1()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            ControlLogic.Login(nameTextBox.Text, passwordTextBox.Text, this);

            //if (nameTextBox.Text == sdb.getFromUsers(selectFromUsers.username, nameTextBox.Text))
            //{
            //    if (passwordTextBox.Text == sdb.getPassword(nameTextBox.Text))
            //    {
            //        PWRegister registerForm = new PWRegister();
            //        this.Hide();
            //        registerForm.ShowDialog();
            //    }
            //    else if (nameTextBox.Text == sdb.getFromUsers(selectFromUsers.email, nameTextBox.Text))
            //    {
            //        if (passwordTextBox.Text == sdb.getPassword(nameTextBox.Text))
            //        {
            //            PWRegister registerForm = new PWRegister();
            //            this.Hide();
            //            registerForm.ShowDialog();
            //        }
            //    }

            //}
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            PWRegister registerForm = new PWRegister();
            this.Hide();
            registerForm.ShowDialog();
        }
    }
}
