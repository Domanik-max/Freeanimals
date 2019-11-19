using System;
using Shelter.Handler;
using Serilog;


namespace Shelter.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Created Logger
           Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();

            //Injecting class that contains all methods 
            Repo _repo = new Repo();

            //Keep track of answers
            string ans;
            
            //Start of Console Application
            while (true)
            {
                Log.Information("Start of Program");
               //Printing main menu to console
               Console.WriteLine(_repo.ShowTitle());
               //Getting ans
               ans = Console.ReadLine();
                if (ans != "exit")
                {
                    //Exception handling
                    try
                    {
                        //Switch to choose between customer and admin
                        switch (int.Parse(ans))
                        {
                            // Customer Menu
                            case 1:
                               Console.WriteLine(_repo.CustomerMenuArt());
                  srmenu:      Console.WriteLine($"Press[1]: Sign In\nPress[2]: Register");
                                 ans = Console.ReadLine();
                                try
                                {
                                    //Exceptional handling for Signin/Reg menu
                                    if (int.Parse(ans) == 1)
                                    {
                                        //Call Sign in Method
                                        Console.WriteLine("Signin");
                                    }
                                    else if (int.Parse(ans) == 2)
                                    {
                                        //Call Register Method
                                        Console.WriteLine("Register");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Input! Try again");
                                        goto srmenu;
                                    }
                                }catch(Exception e)
                                {
                                    //Have to Log error
                                    Console.WriteLine("Numbers only! Try again");
                                    goto srmenu;

                                }


                                break;
                            // Admin Menu
                            case 2:
                                _repo.AdminMenuArt();
                                break;
                        }
                    }
                    // Base exception
                    catch (Exception e)
                    {
                        Console.WriteLine("Invalid Input! Try again");
                        continue;
                    }
                }
                break;
            }
            Console.WriteLine("Out of loop");
        }
    }
}
