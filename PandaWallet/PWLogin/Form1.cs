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
            if(nameTextBox.Text == sdb.getUser(nameTextBox.Text))
                {
                PWRegister registerForm = new PWRegister();
                this.Hide();
                registerForm.ShowDialog();
            }
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            PWRegister registerForm = new PWRegister();
            this.Hide();
            registerForm.ShowDialog();
        }
    }
}
