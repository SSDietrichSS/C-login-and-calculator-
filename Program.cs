﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using logowanie.Login;
namespace logowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            login log = new login();
            log.trylogin();
        }
    }
}
