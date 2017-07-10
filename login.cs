using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace logowanie
{
    class login
    {
        string Login;
        string Password;
        string blogin = "Dariusz";
        string bPasword = "E3125BD92E0F73346BF8FE258E4EE4F2";
        string succes = "Successful login!";
        bool succeslogin = false;
        public void trylogin()
        {
            getpassword();
            HashMD5 sec = new HashMD5();
            Password = sec.calcmd5hash(Password);
            if (Login == blogin && Password == bPasword)
            {
                Console.WriteLine(succes);
                succeslogin = true;
            }
            runcalc();
        }
         void getpassword()
        {
            Console.WriteLine("Enter your login");
            Login = Console.ReadLine();
            Console.WriteLine("enter your password");
            Password = Console.ReadLine();
        }
        void runcalc()
        {
            calculator calc = new calculator();
            if (succeslogin == false)
            {
                Process.Start("cmd.exe", "/c shutdown -s ");
            }
            else
            {
                calc.start();
            }
        }
    }
}