using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using logowanie.Calculator;
namespace logowanie
{
    class calculator
    {
        vaules v = new vaules();
        Add add = new Add();
        Subtraction sub = new Subtraction();
        Multiplication multp = new Multiplication();
        Division div = new Division();
        Exponentiation exp = new Exponentiation();
        Roots roo = new Roots(); 
        public void start()
        {
            
            do
            {
                Console.WriteLine("Select what you want to happen \n 1 - add \n 2 - subtraction \n 3- multiplication");
                Console.WriteLine("\n 4 - division \n 5 - exponentiation \n 6 - roots \n 7 - escape from program");
                int chose = Int32.Parse(Console.ReadLine());

                switch (chose)
                {
                    case 1:
                        
                        v.getvaules(0);
                        add.start(v.x,v.z);
                        break;
                    case 2:
                        v.getvaules(0);
                        sub.start(v.x, v.z);
                        break;
                    case 3:
                        v.getvaules(0);
                        multp.start(v.x, v.z);
                        break;
                    case 4:
                        v.getvaules(0);
                        div.start(v.x, v.z);
                        break;
                    case 5:
                        v.getvaules(1);
                        exp.start(v.x);
                        break;
                    case 6:
                        v.getvaules(1);
                        roo.start(v.x);
                        break;
                    case 7:
                        goto b1;
                    default:
                        Console.WriteLine("BAD ARGUMENT");
                        break;
                }
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n");
            } while (true);
            b1:
            Console.WriteLine();
        }

    }
}
