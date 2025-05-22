using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitsApp
{
    public  class FruitsField
    {

        
        internal int choice;// internal field

        // it allows user to pick 3 fruits
        protected int turns = 0;//private filed

        private String[] arrayFruits = new String[6] { "Banana", "Blueberry", "Cherry", "Apple", "Cucumber", "Orange " };





        //method with an array parameter 
        //method allows user to pick fruits
        public  void PickMethod()
        {
            
            do
            {
                try
                {
                    Console.Write("Enter a number from 1 to 6 to pick a fruit : ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    // check if the entered choice is out of the range of the array
                    if (choice >= 1 && choice <= arrayFruits.Length)
                    {
                        //check if the fruits has not been eaten
                        if (arrayFruits[choice - 1] == "Eaten")
                        {
                            Console.WriteLine(" OOPS!! this has already been eaten choose another one ");
                        }
                        else
                        {
                            Console.WriteLine(arrayFruits[choice - 1] + " Has been eaten ");
                            arrayFruits[choice - 1] = "Eaten";
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
        public  void PrintMethod()
        {
            
            for (int i = 0; i < arrayFruits.Length; i++)
            {
                Console.WriteLine((i + 1) + "." + arrayFruits[i]);
            }
        }

        //method that reset picked fruits
        public void resetTurns()
        {
            arrayFruits = new string[6] { "Banana", "Blueberry", "Cherry", "Apple", "Cucumber", "Orange" };
            turns = 0;
        }


        
    }
}
