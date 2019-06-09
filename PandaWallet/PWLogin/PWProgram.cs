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
    public partial class PWProgram : Form
    {
        SingleDB sdb = SingleDB.getInstance();
        public PWProgram()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(sdb.SelectByIdentity(selectIdOrPw.id, ControlLogic.loggedInUser));
            int value = int.Parse(txtBox_Money.Text);
            int IsIncome;
            if (chckBox_IsIncome.Checked)
            { IsIncome = 1; }
            else
            { IsIncome = 0; }
            sdb.InsertToMoneyFlow(value, IsIncome, DateTime.Now, id);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
