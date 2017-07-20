using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logowanie.Login
{
    class GetData
    {
        public string Login;
        public string Password;
        public void getpassword()
        {
            Console.WriteLine("Enter your login");
            Login = Console.ReadLine();
            Console.WriteLine("enter your password");
            Password = Console.ReadLine();
        }
    }
}
