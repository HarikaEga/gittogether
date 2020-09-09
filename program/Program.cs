using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b;
                int sum = 0;
                int product = 0;
                Console.WriteLine("Enter first number");
                a = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Enter second number");
                b = Convert.ToInt32(Console.ReadLine());
                while(a==0 || b==0)
                {
                    if(a==0)
                    {
                        Console.WriteLine("Enter first number again");
                        a = Convert.ToInt32(Console.ReadLine());
                    }
                    else if(b==0)
                    {
                        Console.WriteLine("Enter second number again");
                        b = Convert.ToInt32(Console.ReadLine());
                    }
                }
                sum = a + b;
                product = a * b;
                Console.WriteLine("Sum:{0}", sum);
                Console.WriteLine("Product:{0}", product);




            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
