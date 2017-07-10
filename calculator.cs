using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logowanie
{
    class calculator
    {
        string recommendation = "Enter vaules in order: operator x, operator z";
        string recommendation2 = "Enter vaules in order: operator x";
        double x;
        double z;
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
                        add();
                        break;
                    case 2:
                        subtraction();
                        break;
                    case 3:
                        multiplication();
                        break;
                    case 4:
                        division();
                        break;
                    case 5:
                        exponentiation();
                        break;
                    case 6:
                        roots();
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


        void getvaules(int c)
        {
            if (c == 0)
            {
                x = Convert.ToDouble(Console.ReadLine());
                z = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                x = Convert.ToDouble(Console.ReadLine());
            }
        }

        void add()
        {
            Console.WriteLine(recommendation);
            getvaules(0);
            x += z;
            Console.WriteLine("result = " + x);
        }
        void subtraction()
        {
            Console.WriteLine(recommendation);
            getvaules(0);
            x -= z;
            Console.WriteLine("result = " + x);
        }
        void multiplication()
        {
            Console.WriteLine(recommendation);
            getvaules(0);
            x *= z;
            Console.WriteLine("result = " + x);

        }
        void division()

        {
            Console.WriteLine(recommendation);
            getvaules(0);
            x /= z;
            Console.WriteLine("result = " + x);


        }
        void exponentiation()
        {
            Console.WriteLine(recommendation2);
            getvaules(1488);
            x *= x;
            Console.WriteLine("result = " + x);


        }
        void roots()
        {
            Console.WriteLine(recommendation2);
            getvaules(2137);
            x = Math.Sqrt(x); ;
            Console.WriteLine("result = " + x);


        }
    }
}
