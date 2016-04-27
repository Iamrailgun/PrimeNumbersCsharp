using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbersCsharp
{
    class Checker
    {
        private static Form1 form = new Form1();
        public static String check(int num)
        {
            Boolean prime = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            if (prime)
            {
                return "Is prime";
            }
            else
            {
                return "Is composite number";
            }
        }
    }
}
