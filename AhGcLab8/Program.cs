using System;

namespace AhGcLab8
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool UserContinue = true;
            while (true)
            {
                try

                {

                    string[] Students = { "Ak", "Earnest", "James", "Jason", };
                    string[] HomeTown = { "Detroit", "West Bloomfield", "Warren", "Dearborn" };
                    string[] FavFood = { "Pasta", "Tacos", "peperjack cheese", "oatmeal cookies" };

                    Console.WriteLine("Welcome! from number 1-4 which student would you like to learn about!");
                    int UserInput = int.Parse(Console.ReadLine());
                    //while (!int.TryParse(Console.ReadLine(), out UserInput) || UserInput < 1 || UserInput > 5)
                    //{
                    //    Console.WriteLine("Invalid input. Please enter number between 1 and 4.");
                    //}

                    
                    
                        Console.WriteLine("Student " + UserInput + " is " + Students[UserInput - 1] + 
                            ". What would you like to know about " + Students[UserInput - 1] +
                            "? (enter \"Hometown\" or \"Favorite Food\")");


                        string choice1 = Console.ReadLine();
                        if (choice1.ToLower().Contains("hometown"))
                        {
                            Console.WriteLine(HomeTown[UserInput - 1]);
                            //UserContinue = false;
                        }
                        else if (choice1.ToLower().Contains("favorite food"))
                        {
                            Console.WriteLine(FavFood[UserInput - 1]);
                            //UserContinue = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Try again.");
                        }





                    Console.WriteLine("Would you like to continue?(y/n)");
                    string userInput2 = Console.ReadLine().ToLower();
                    if (userInput2 == "n")
                    {
                        break;
                    }

                }



                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The number you entered is out of range. Please enter an integer between 1 to 4.");

                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter an integer between 1 to 4");
                }
            }
            }
           

        }
    }



    
    

        
    

