using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuction_Work
{
    class Program
    {
        static void gatherInformation() //No Return Type No Parameter //Void-Nothing
        {
            string fname, lname;
            Console.WriteLine("Enter the first name of employee");
            fname = Console.ReadLine();
            Console.WriteLine("Enter the last name of employee");
            lname = Console.ReadLine();
            Console.WriteLine("The full name of Employee is:" + fname + " " + lname);




        }
        // q1: how to execute this?
        static void Main(string[] args)
        {
            Console.WriteLine("How many employees do you want to register:");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Information of Employee Number:" + (i + 1));
                gatherInformation();
            }

            Console.ReadKey();
        }
        
    }
}
