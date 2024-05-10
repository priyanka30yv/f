using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
   internal  abstract class arithmetic
    { 
    public void add(int num1,int num2)
        {
            Console.WriteLine("the addition of{0} and {1} is {2}", num1, num2, (num1 + num2));

        }
        public abstract void multi(int num1, int num2);
        public abstract void divide(int num1, int num2);
    }
    internal class excel : arithmetic {
    public override void multi(int num1,int num2)
        {
            Console.WriteLine("the multiplication of {0} and {1} is {2}",num1,num2, (num1 * num2));   
        }
        public override  void divide(int num1,int num2)
        {
            Console.WriteLine("the division of {0} and {1} is {2}", num1, num2, (num1/ num2));
        }
    
    }


}
