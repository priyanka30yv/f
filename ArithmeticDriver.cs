using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment1
{
    internal class ArithmeticDriver
    {public static void Main(string[] args) {
            excel obj1 = new excel();
            obj1.multi(10, 20);
            obj1.divide(10, 5);
            obj1.add(10, 20);
                }
    }
}
