using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWLogin
{
    public class ControlLogic
    {
        static SingleDB sdb = SingleDB.getInstance();

        public static void Login(string name, string password, Form1 form)
        {

            if (name == sdb.getFromUsers(selectFromUsers.username, name))
            {
                if (password == sdb.getPassword(password))
                {
                    PWRegister registerForm = new PWRegister();
                    form.Hide();
                    registerForm.ShowDialog();
                }
                else if (name == sdb.getFromUsers(selectFromUsers.email, name))
                {
                    if (password == sdb.getPassword(password))
                    {
                        PWRegister registerForm = new PWRegister();
                        form.Hide();
                        registerForm.ShowDialog();
                    }
                }
            }
        }
    }
}
