using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Bravo
   
{
    class Program
    { static List<string> nam = new List<string>();

        static void gatherinformation()
        {

            string F_name, L_name;
            Console.WriteLine("Please put in the employee's first name");
            F_name = Console.ReadLine();
            Console.WriteLine("Please put in the employee's last name");
            L_name = Console.ReadLine();
            Console.WriteLine("The employee's name is " + F_name + " " + L_name);
            nam.Add(F_name + " " + L_name);

        }



        static void storedinfo()
        {

            Console.WriteLine("The stored stored Employee Information:");
            for (int i = 0; i > nam.Count; i++)

            { Console.WriteLine("Employee:" + i + " " + nam[i]); }
        }

        static void insertinfo()
        {
            Console.WriteLine("Which place do you want to insert the information");
            int num = int.Parse(Console.ReadLine());
            string F_name, L_name;
            Console.WriteLine("Please put the employee's first name");
            F_name = Console.ReadLine();
            Console.WriteLine("Please put the employee's last name");
            L_name = Console.ReadLine();
            nam.Insert(num, F_name + " " + L_name);
        }

        static void deleteinfo()
        {

            Console.WriteLine("Whitch place do you want to delete the information");
            int num = int.Parse(Console.ReadLine());
            nam.RemoveAt(num);
        }

        static void searchinfo()
        {
            Console.WriteLine("Please put the Employee's details" +
                "\nto -Search- their information");
            Console.WriteLine("Put the Employee's first name");
            string F_name = Console.ReadLine();
            Console.WriteLine("Put the Employee's last name");
            string L_name = Console.ReadLine();


            if (nam.Contains(F_name + " " + L_name))
            {
                Console.WriteLine("The Employee: " + F_name + " " + L_name + "' information does exist at this place: " + nam.IndexOf(F_name + " " + L_name));
            }
            else
            {
                Console.WriteLine("The Emplyee: " + F_name + " " + L_name + "' information does not exist in the record!!! Please try another name");
            }



        }

        static void updateinfo()
        {

            Console.WriteLine("Whitch place do you want to delete the information");
            int num = int.Parse(Console.ReadLine());
            string F_name, L_name;
            Console.WriteLine("Please enter the Emplyee's first name");
            F_name = Console.ReadLine();
            Console.WriteLine("Please enter the Emplyee's last name");
            L_name = Console.ReadLine();
            nam[num] = (F_name + L_name);
        }








        // Q1: how do you execute this?
        static void main(String[] arg)

        { int yes;

            do 
            {

                Console.WriteLine("============Emplyee Information============");
                Console.WriteLine("PLease enter '1' to resgister information");
                Console.WriteLine("PLease enter '2' to insert information");
                Console.WriteLine("PLease enter '3' to update information");
                Console.WriteLine("PLease enter '4' to delete information");
                Console.WriteLine("PLease enter '5' to search information");
                Console.WriteLine("PLease enter '6' to store information");
                string choice = Console.ReadLine();
                switch (choice)
                {

                    case "1":
                        Console.WriteLine("How many Emplyee's you want to register:");
                        int num;
                        num = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < num; i++)
                        {
                            Console.WriteLine("Information of the Employee's number:" + (i + 1));
                            gatherinformation();
                        }
                        break;
                    case "2":
                        Console.WriteLine("You have to select the insert information option");
                        insertinfo();
                        break;
                    case "3":
                        Console.WriteLine("You have to select the update information option");
                        updateinfo();
                        break;
                    case "4":
                        Console.WriteLine("You have to select the delete information option");
                        deleteinfo();
                        break;
                    case "5":
                        Console.WriteLine("You have to select the search information option");
                        searchinfo();
                        break;
                    case "6":
                        Console.WriteLine("You have to select the store information option");
                        storedinfo();
                        break;

                }
                Console.WriteLine("If you want to continue press 0");
                yes = int.Parse(Console.ReadLine());
            } while (yes == 0) ;
            Console.ReadKey();

      


        }

    }
}

        
    

