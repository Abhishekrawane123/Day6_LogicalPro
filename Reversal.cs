using System;
using System.Collections.Generic;
using System.Text;

namespace day6_LogicalPro
{
    class Reversal
    {
      

        public static string reversaln(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        static int reversDigits(int num)
        {
            string strin = num.ToString();

            // reversing the string
            strin = reversaln(strin);

            // converting string to integer
            num = int.Parse(strin);

            // returning integer
            return num;
        }

        // Driver code
        static public void reversal()
        {
            
            int num = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Reverse of no. is "
                               + reversDigits(num));
        }
    }



}

