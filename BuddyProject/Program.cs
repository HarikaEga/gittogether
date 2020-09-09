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
            int num1 = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("Enter the value of second number");
            int num2 = Convert.ToInt32((Console.ReadLine()));
            int sum = num1 + num2;
            int product = num1 * num2;
            if (num1==0)
            {
                Console.WriteLine("You cannot enter the value of a number 0,enter the value again");
                int num3 = Convert.ToInt32((Console.ReadLine()));
                sum = num3 + num2;
                product = num3 * num2;
            }
            else if(num2==0)
            {
                Console.WriteLine("You cannot enter the value of a number 0,enter the value again");
                int num3 = Convert.ToInt32((Console.ReadLine()));
                sum = num3 + num1;
                product = num3 * num1;
            }
            Console.WriteLine("\nThe sum of two numbers is : {0} \n", sum);
            Console.WriteLine("\nThe product of two numbers is : {0} \n", product);
            Console.ReadKey();



        }
    }
}
