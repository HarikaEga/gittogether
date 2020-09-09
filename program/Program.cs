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
               int divide = 0;
                Console.WriteLine("Enter first number");
                a = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Enter second number");
                b = Convert.ToInt32(Console.ReadLine());
               
                    if(a==0)
                    {
                        Console.WriteLine("Enter first number again it should not be 0");
                        a = Convert.ToInt32(Console.ReadLine());
                    }
                    else if(b==0)
                    {
                        Console.WriteLine("Enter second number again it should not be 0");
                        b = Convert.ToInt32(Console.ReadLine());
                    }
               
                sum = a + b;
                product = a * b;
                divide = a / b;
                Console.WriteLine("Sum:{0}", sum);
                Console.WriteLine("Product:{0}", product);
                Console.WriteLine("Divide:{0}", divide);




            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
