using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace logowanie.Login
{
    class login
    {
        GetData D = new GetData();
        string blogin = "Dariusz";
        string bPasword = "E3125BD92E0F73346BF8FE258E4EE4F2";
        string succes = "Successful login!";
        runcalc rc = new runcalc();
        public void trylogin()
        {
            
            D.getpassword();
            HashMD5 sec = new HashMD5();
            D.Password = sec.calcmd5hash(D.Password);
            if (D.Login == blogin && D.Password == bPasword)
            {
                Console.WriteLine(succes);
                rc.succeslogin = true;
            }
            rc.runcal();
        }
    }
}