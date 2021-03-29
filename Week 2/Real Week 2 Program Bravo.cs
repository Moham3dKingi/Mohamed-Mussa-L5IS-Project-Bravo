using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Bravo_week_2_work
{
    class Program
    {
       
            static List<string> Employeename = new List<string>();



        static void AddInformation() //This is the function the loop calls fro at the bottom
        {



            string Employee; //string name
            int num;
            Console.WriteLine("How many Employee names do you want to add more");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)//code that adds up the amount of employees you want to add
            {
                Console.WriteLine("Enter the name of the Employee's" +
                    ":" + (i + 1));
                Employee = Console.ReadLine();  //it always add the elements at the end of the list
                Employeename.Add(Employee);
            }
        }
        static void DisplayInformation()//this is the display function that is called when you press a button
        {
            Console.WriteLine("Information Stored are as follows:");
            for (int i = 0; i < Employeename.Count; i++) // this shows the location number of employee you added
            {
                Console.WriteLine("The employees are:" + Employeename[i]);//print line plus employee entered
            }



        }
        static void InsertInfo()//this is the Insert function that is called when you press a button
        {
            DisplayInformation();
            Console.WriteLine("Enter the location number of the employee you want to insert");
            int loc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee full name");
            string fname = Console.ReadLine();
            Employeename.Insert(loc, fname);
            DisplayInformation();



        }



        static void UpdateInfo()
        {
            Console.WriteLine("The list of previously entered employee names for refrence");
            DisplayInformation();
            Console.WriteLine("Enter the location you want to update:");
            int loc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the updated information for the location you entered:");
            string element = Console.ReadLine();
            Employeename[loc] = element;
            Console.WriteLine("You now have succesfully updated your information, this is how it looks");
            DisplayInformation();
        }



        static void DeleteInfo()
        {
            //Method to delete the information from a specific location           
            {
                Console.Clear(); //clear the output screen
                Console.WriteLine("===========Delete Information===========");



                Console.WriteLine("List of Employees before Delete:");
                DisplayInformation();
                Console.WriteLine("Enter the location number to delete element:");
                int loc = Convert.ToInt32(Console.ReadLine());
                Employeename.RemoveAt(loc);
                Console.WriteLine("Employee name successfully deleted");
                Console.WriteLine("List of Employee after Delete:");
                DisplayInformation();



            }



        }



        static void SearchInfo()
        {
            {
                Console.WriteLine("Enter the element to search:");
                string element = Console.ReadLine();



                if (Employeename.Contains(element))

                    Console.WriteLine("This employee name: " + element + " exist on location: " + Employeename.IndexOf(element));

                else



                    Console.WriteLine("The employee name your trying to search does not exist!!!!!! Try another name");
            }



        }
        static void Main(string[] args)
        {
            char c;
            do
            {
                Console.Clear();
                Console.WriteLine("=============== Employee Innformation ================");
                Console.WriteLine("Press 1 for Add Informatione");
                Console.WriteLine("Press 2 for Insert Information");
                Console.WriteLine("Press 3 for Update Information");
                Console.WriteLine("Press 4 for Delete Information");
                Console.WriteLine("Press 5 for Search Information");
                Console.WriteLine("Press 6 for Display Information");
                int choice;
                choice = Convert.ToInt32(Console.ReadLine());
                char ch;
                switch (choice)
                {
                    case 1:
                        do
                        {
                            AddInformation();
                            Console.WriteLine("Do you want to add more: Press 'y/Y' for Yes or 'n' for No");
                            ch = Convert.ToChar(Console.ReadLine());
                        } while (ch == 'y' || ch == 'Y');
                        ;
                        break;
                    case 2:
                        do
                        {
                            InsertInfo();
                            Console.WriteLine("Do you want to Insert more elements: Press 'y/Y' for Yes or 'n' for No");
                            ch = Convert.ToChar(Console.ReadLine());
                        } while (ch == 'y' || ch == 'Y');
                        break;
                    case 3:
                        do
                        {
                            UpdateInfo();
                            Console.WriteLine("Do you want to Insert more elements: Press 'y/Y' for Yes or 'n' for No");
                            ch = Convert.ToChar(Console.ReadLine());
                        } while (ch == 'y' || ch == 'Y');
                        break;
                    case 4:
                        do
                        {
                            DeleteInfo();
                            Console.WriteLine("Do you want to Delelte more elements: Press 'y/Y' for Yes or 'n' for No");
                            ch = Convert.ToChar(Console.ReadLine());
                        } while (ch == 'y' || ch == 'Y');
                        break;
                    case 5:
                        do
                        {
                            SearchInfo();
                            Console.WriteLine("Do you want to Search more elements: Press 'y/Y' for Yes or 'n' for No");
                            ch = Convert.ToChar(Console.ReadLine());
                        } while (ch == 'y' || ch == 'Y');



                        break;
                    case 6:
                        DisplayInformation();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Choose number between 1 and 6");
                        break;
                }
                Console.WriteLine("Do you want to go back to the Main Menu: Press 'y/Y' for Yes");
                c = Convert.ToChar(Console.ReadLine());
            } while (c == 'y' || c == 'Y');
            Console.ReadKey();
        }



    }



}

