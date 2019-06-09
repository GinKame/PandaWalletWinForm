using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWLogin
{
    class ControlLogic
    {
        static SingleDB sdb = SingleDB.getInstance();

        /// <summary>
        /// A bejelentkezés gomb logikája
        /// </summary>
        /// <param name="name">első textbox értéke (felhasználónév/email)</param>
        /// <param name="password">Második textbox értéke (jelszó)</param>
        /// <param name="form">Maga a form, ha be kéne azt zárni</param>
        public static void Login(string name, string password, Form1 form)
        {

            if (name == sdb.getFromUsers(selectFromUsers.username, name))
            {
                if (password == sdb.getPassword(name))
                {
                    PWRegister registerForm = new PWRegister();
                    form.Hide();
                    registerForm.ShowDialog();
                }
            }
            else if (name == sdb.getFromUsers(selectFromUsers.email, name))
            {
                if (password == sdb.getPassword(name))
                {
                    PWRegister registerForm = new PWRegister();
                    form.Hide();
                    registerForm.ShowDialog();
                }
            }
        }

        /// <summary>
        /// A bejelentkezés formjának regisztrációs gombja
        /// </summary>
        /// <param name="form">A bejelentkező form maga, bezárásához szükséges</param>
        public static void MainRegister(Form1 form)
        {
            PWRegister registerForm = new PWRegister();
            form.Hide();
            registerForm.ShowDialog();
        }
    }
}
