using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class delegate1
    {
        delegate int mydel();
        delegate int yourdel(int a);
        public static void Main(string[] args)
        {
            mydel obj1 = new mydel(greet);
            mydel obj4 = new mydel(merrchristmas);
            obj1();
            obj4();
            yourdel obj2 = new yourdel(odd);
            yourdel obj3 = new yourdel(even);
            int num1 = obj2(7);
            int num2 = obj3(6);
      
        }
      
        static int  greet()
        {
            Console.WriteLine("greet");
            return 0;

        }
        static int merrchristmas()
        {
            Console.WriteLine("marry christmas");
        
            return 0;
        }
        static int odd(int a)
        {
         if(a%2!=0)
            {
                Console.WriteLine("{0} is odd",a);
            }
            return 0;
        }
        static int even(int a)
        {

            if (a % 2 == 0)
            {
                Console.WriteLine("{0} is even",a);
            }
            return 0;
        }
    }
    }

