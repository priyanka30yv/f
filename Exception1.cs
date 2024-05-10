using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Exception1
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter 1st number");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter 2nd number");
                int num2 = Convert.ToInt32(Console.ReadLine());

                float res = num1 + num2;
                Console.WriteLine("answer is :"+res);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("enter right input");

            }
            catch (Exception ex)
            {
                Console.WriteLine("enterv right input");
            }
        }
    }
}
