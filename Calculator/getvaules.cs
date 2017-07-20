using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logowanie.Calculator
{
    class vaules
    {
       public double x;
       public double z;
        string recommendation = "Enter vaules in order: operator x, operator z";
        string recommendation2 = "Enter vaules in order: operator x";
       public void getvaules(int c)
        {
            if (c == 0)
            {
                Console.WriteLine(recommendation);
                x = Convert.ToDouble(Console.ReadLine());
                z = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                Console.WriteLine(recommendation2);
                x = Convert.ToDouble(Console.ReadLine());
            }
        }
    }
}
