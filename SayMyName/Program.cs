using System;
using System.Linq.Expressions;
using System.Net.Security;

namespace SayMyName
//Sturm Savage
//RCET2265
//Spring Semester
//https://github.com/savastur/SayMyName.git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String userInput;
            bool isValid = false;
            

            do
            {
               
                Console.WriteLine("Please write your name:");
                Console.WriteLine("Enter \"Q\" to quit.");
                 userInput = Console.ReadLine();
                
                            
                //End loop
                if (userInput == "q" || userInput == "Q")
                {
                    Console.WriteLine("Have a nice day!!");
                    isValid= true;

                }
                //Name Repository                
                else
                {
                                                                                        
                    switch (userInput)
                    {
                        case "Joe":
                            Console.WriteLine($"Hello {userInput}, do you want to revisit your last search?");
                            if (userInput == "yes")
                            {
                                Console.WriteLine("Your last search was: How do you make pickles ");
                            }
                            break;
                        case "Emily":
                            Console.WriteLine($"Hello {userInput}, how are you?");
                            
                            break;
                        case "Sturm Savage":
                            Console.WriteLine($" {userInput} is a special needs case.");
                            break;
                                                 
                    }
                                                            
                    //Any other name
                    if (userInput != "Joe , Emily , Sturm Savage")
                    {
                        Console.WriteLine($"Hello {userInput}!!!!");

                    }

                }
            
            } 
            while (!isValid);
            
            
            //Pause
            Console.Read();
        }
    }
}