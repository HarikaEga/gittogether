using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuddyProject
{
    class numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of first number");
            int a = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("Enter the value of second number");
            int b = Convert.ToInt32((Console.ReadLine()));
            int sum = a + b;
            int product = a * b;
            if (a==0)
            {
                Console.WriteLine("You cannot enter the value of a number 0,enter the value again");
                int num3 = Convert.ToInt32((Console.ReadLine()));
                sum = num3 + b;
                product = num3 * b;
            }
            else if(b==0)
            {
                Console.WriteLine("You cannot enter the value of a number 0,enter the value again");
                int num3 = Convert.ToInt32((Console.ReadLine()));
                sum = num3 + a;
                product = num3 * a;
            }
            Console.WriteLine("\nThe sum of two numbers is : {0} \n", sum);
            Console.WriteLine("\nThe product of two numbers is : {0} \n", product);
            Console.ReadKey();



        }
    }
}
