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
    public partial class PWRegister : Form
    {
        SingleDB sdb = SingleDB.getInstance();

        public PWRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlLogic.RegRegister(txtBox_uName.Text, txtBox_email.Text, txtBox_Password.Text, txtBox_Password2.Text, this);
        }
    }
}
