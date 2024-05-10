using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class InterfaceSalaryMain
    {
        public static void Main(string[] args)
        {
            Salary obj;
            string choice;
            Console.WriteLine("enter a choice");
            choice = Console.ReadLine();
            switch (choice.ToLower()) {
                case "trainersalary":
                    obj = new trainersal();
                    break;

                case "projectmanager":
                    obj = new projectManager();
                    break;
                default:
                    obj = null;
                    Console.WriteLine("invalid choice");
                    break;
            
            
            
            }

            obj.calchra(5000);
            obj.calda(5000);
        }
    }
}
