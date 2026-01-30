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
            String Userinput;
            bool isvalid = false;

            do
            {
               
                Console.Write("Please write your name:");
                Console.Write("Enter \"Q\" to quit.");
                 Userinput = Console.ReadLine();
                
                            

                if (Userinput == "q" || Userinput == "Q")
                {
                    Console.WriteLine("Have a nice day!!");
                    isvalid= true;

                }

                

                else
                {
                    switch (Userinput)
                    {
                        case "Joe":
                            Console.WriteLine($"Hello {Userinput}, do you want to revisit your last search?");
                            if (Userinput == "yes")
                            {
                                Console.WriteLine("Your last search was: How do you make pickles ");
                            }
                            break;
                        case "Emily":
                            Console.WriteLine($"Hello {Userinput}, how are you?");
                            
                            break;
                        case "Sturm Savage":
                            Console.WriteLine($" {Userinput} is a special needs case.");
                            break;
                        



                    }
                    if (Userinput != "Joe , Emily , Sturm Savage")
                    {
                        Console.WriteLine($"Hello {Userinput}!!!!");

                    }

                }
            
            } 
            while (!isvalid);
            
            


            Console.Read();
        }
    }
}