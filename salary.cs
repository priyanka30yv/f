using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
  interface Salary
    {
        void calchra(float basic);
        void calda(float basic);    
    }
    class trainersal : Salary
    {
        public void calchra(float basic)
        {
            float hra = basic * 0.2f;
            Console.WriteLine("will calculate the hra " + hra);
        }
        public void calda(float basic) {
            float cda = basic * 0.2f;
            Console.WriteLine("will calculate the cda " +cda );
        }

    }
    class projectManager : Salary
    {
        public void calchra(float basic)
        {
            float hra = basic * 0.2f;
            Console.WriteLine("will calculate the hra " +hra);
        }
        public void calda(float basic)
        {
            float cda = basic * 0.2f;
            Console.WriteLine("will calculate the cda " + cda);
        }

    }

}
