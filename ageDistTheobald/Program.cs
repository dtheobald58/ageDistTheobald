using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageDistTheobald
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age.");

            int userage = int.Parse(Console.ReadLine());

            if ((userage >= 0) && (userage <= 2))
            {
                Console.WriteLine("Still in Mama's arms");
            }
            else if (userage == 3 || userage == 4)
            {
                Console.WriteLine("Preschool Maniac");
            }
            else if ((userage >= 5) && (userage <= 11))
            {
                Console.WriteLine("Elementary school");
            }
            else if ((userage >= 12) && (userage <= 14))
            {
                Console.WriteLine("Middle school");
            }
            else if ((userage >= 15) && (userage <= 18))
            {
                Console.WriteLine("High school");
            }
            else if ((userage >= 19) && (userage <= 22))
            {
                Console.WriteLine("College");
            }
            else if ((userage >= 23) && (userage <= 65))
            {
                Console.WriteLine("Working for the man");
            }
            else if ((userage >= 66) && (userage <= 100))
            {
                Console.WriteLine("The Golden Years");
            }
            else if ((userage < 0) || (userage > 100))
            {
                Console.WriteLine("This program is for humans");
            }
        }
    }
}
