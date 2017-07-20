using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logowanie.Login
{
    class runcalc
    {
        public bool succeslogin = false;
        public void runcal()
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