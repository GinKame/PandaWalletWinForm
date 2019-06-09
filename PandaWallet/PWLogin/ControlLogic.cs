using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWLogin
{
    class ControlLogic
    {

        public static string loggedInUser;
        static SingleDB sdb = SingleDB.getInstance();

        /// <summary>
        /// A bejelentkezés gomb logikája
        /// </summary>
        /// <param name="name">első textbox értéke (felhasználónév/email)</param>
        /// <param name="password">Második textbox értéke (jelszó)</param>
        /// <param name="form">Maga a form, ha be kéne azt zárni</param>
        public static void Login(string name, string password, Form1 form)
        {

            if (name == sdb.Select(selectFromUsers.username, name))
            {
                if (password == sdb.SelectByIdentity(selectIdOrPw.password, name))
                {
                    loggedInUser = name;
                    PWProgram program = new PWProgram();
                    form.Hide();
                    program.ShowDialog();
                }
            }
            else if (name == sdb.Select(selectFromUsers.email, name))
            {
                if (password == sdb.SelectByIdentity(selectIdOrPw.password, name))
                {
                    loggedInUser = name;
                    PWProgram program = new PWProgram();
                    form.Hide();
                    program.ShowDialog();
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

        /// <summary>
        /// A regisztrációs form gombjának logikája
        /// </summary>
        /// <param name="uName">Megadott felhasználónév</param>
        /// <param name="email">Megadott email cím</param>
        /// <param name="passw">Megadott jelszó</param>
        /// <param name="passw2">Megadott jelszó ismételten</param>
        /// <param name="form">Maga a form, hogy bezárásra kerülhessen</param>
        public static void RegRegister(string uName, string email, string passw, string passw2, PWRegister form)
        {
            if (sdb.Select(selectFromUsers.username, uName) == uName)
                Console.WriteLine("Már létezik ilyen nevű felhasználó!");
            else
            {
                if (!email.Contains("@") || !email.EndsWith(".hu") || !email.EndsWith(".com"))
                    Console.WriteLine("Ez nem egy email cím!");
                else if (sdb.Select(selectFromUsers.email, email) == email)
                    Console.WriteLine("Ezzel az email címmel már regiszráltak!");
                else
                {
                    if (passw != passw2)
                    {
                        Console.WriteLine("A két jelszó nem egyezik!");
                    }
                    else
                    {
                        sdb.InsertToUsers(uName, passw, email);
                        Form1 logInForm = new Form1();
                        form.Hide();
                        logInForm.ShowDialog();
                    }
                }
            }
        }
    }
}
