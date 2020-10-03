using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 2;
            bool needvalue = false; Start:
            Console.WriteLine("1-Next finding prime 2 -End search");
            int input = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        FindingPrime();
                        goto Start;   
                    case 2:
                        continue;                      
                }
            }
            void FindingPrime()
            {
                while (true)
                {
                    for (int i = 1; i < value; i++)
                    {
                        bool result = value % i == 0 && i !=1;
                        if (result == true) { value++; break; };
                        if (i == value - 1) { Console.WriteLine(value); needvalue = true; }
                    }
                    if (needvalue == true) { needvalue = false;value++; break; }

                }
            }
        }
        
    }
}
