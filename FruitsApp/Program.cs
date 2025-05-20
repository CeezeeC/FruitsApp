using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FruitsApp
{
    class Program
    {

        static void Main(string[] args)
        {
            // creating class object
            FruitsField fruits1 = new FruitsField();

            bool exit = false;
            // Creating an Array of six element the size
            String[] fruits = new String[6]{ "Banana", "Blueberry", "Cherry", "Apple", "Cucumber", "Orange " };
            
            //begining  of the main loop
            //menu will pop up until you choose to exit
            while (!exit)
            {

                Console.WriteLine("***********FRUITS QUICK PICK**********");
                //handle error and expections
                try
                {
                    //Display main menu
                    Console.WriteLine("Please enter (1) to Pick >>>\n"+
                                      "Please entet (2) to Display >>>\n"+
                                      "Please enter (3) to Exit >>> ");
                    int choice = Convert.ToInt32(Console.ReadLine());// choice from user input

                    // the entry of switch statement
                    switch (choice)
                    {
                        case 1:

                            fruits1.PickMethod(fruits);// call method to pick fruit
                            break;

                        case 2:

                            fruits1.PrintMethod(fruits);// call method to display fruit

                            break;
                        case 3:

                            Console.WriteLine("You have choosen to exit Goodbye !!!!!!!!!");
                            exit = true;// exit the loop
                            break;  

                            default:
                            Console.WriteLine(" Incorrect choice ,enter number from 1 to 3 ");
                            break;
                    }
                }
                // catch error and display messege
                catch (Exception ex)
                {
                    
                    Console.WriteLine(ex.Message);
                }
            }
        }
        
      
    }
}
        
    

