using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitsApp
{
    public  class FruitsField
    {

        private string[] fruits;// private field
        internal int choice;// internal field

        // it allows user to pick fruits 3 times
        public int turns = 0;//public filed

        protected int exit = 3;



        //method with an array parameter 
        //method allows user to pick fruits
        public  void PickMethod(string[] fruits)
        {
            
            do
            {
                try
                {
                    Console.Write("Enter a number from 1 to 6 to pick a fruit : ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    // check if the entered choice is out of the range of the array
                    if (choice >= 1 && choice <= fruits.Length)
                    {
                        //check if the fruits has not been eaten
                        if (fruits[choice - 1] == "Eaten")
                        {
                            Console.WriteLine(" OOPS!! this has already been eaten choose another one ");
                        }
                        else
                        {
                            Console.WriteLine(fruits[choice - 1] + " Has been eaten ");
                            fruits[choice - 1] = "Eaten";
                            turns++;//increament, 
                        }
                    }
                    else
                    {
                        Console.WriteLine(" Entered number is out of the range : ");
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            } while (turns < 3);// it repeats until 3 times
        }

        //Display current result using for loop
        public  void PrintMethod(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine((i + 1) + "." + array[i]);
            }
        }


        
    }
}
