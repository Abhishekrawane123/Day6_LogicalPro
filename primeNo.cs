using System;
using System.Collections.Generic;
using System.Text;

namespace day6_LogicalPro
{
    class primeNo
    {
        static int i = 2;

           
            static bool isPrime(int n)
            {

                
                if (n == 0 || n == 1)
                {
                    return false;
                }

                if (n == i)
                    return true;

                if (n % i == 0)
                {
                    return false;
                }
                i++;
                return isPrime(n);
            }

             public static void PrimeNo()
            {
               int n = Convert.ToInt32(Console.ReadLine());
            if (isPrime(n))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }

    }

