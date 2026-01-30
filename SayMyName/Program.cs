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
               
                Console.WriteLine("Please write your name:");
                Console.WriteLine("Enter \"Q\" to quit.");
                 Userinput = Console.ReadLine();
                
                            

                if (Userinput == "q" || Userinput == "Q")
                {
                    isvalid= true;
                }

                

                else
                {
                    switch (Userinput)
                    {
                        case "Joe":
                            Console.WriteLine($"Hello {Userinput}!!!!");
                            break;
                        case "Emily":
                            Console.WriteLine($"Hello {Userinput}!!!!");
                            break;
                        case "Sturm Savage":
                            Console.WriteLine($"Hello {Userinput}. How can I help you?");
                            break;
                        case "q":
                            isvalid = true;
                            break;
                        case "Q":
                            isvalid= true;
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