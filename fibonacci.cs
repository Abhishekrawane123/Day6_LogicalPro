using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace day6_LogicalPro
{
    class fibonacci
    {
        public static void Fibonacci()
        {
            Console.Write("Length of the Fibonacci Series: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;
            Console.Write(a);
            for(int i=1; i<length; i++)
            {
                Console.Write("  " + b);
                int c = a;
                a = b;
                b = c + b;

            }
           
            }
        }
        
            
        
    }

