using System;
using Shelter.Handler;
using Serilog;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace Shelter.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            //using()
            //Instantiated logger
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("/Users/domanikjohnson/Documents/C#GoOver/Freeanimals/Shelter/Shelter/Logging/Log", rollingInterval: RollingInterval.Day)
                .CreateLogger();


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
                                        string userEmail, userPassword;

                                        //Take signin details
                                        Console.WriteLine("Enter username: ");
                                        userEmail = Console.ReadLine();
                                        Console.WriteLine("Enter password: ");
                                        userPassword = Console.ReadLine();
                                        //Call method to signin user
                                        _repo.Signin(userEmail, userPassword);



                                    }
                                    else if (int.Parse(ans) == 2)
                                    {
                                        // Instantiated variables
                                        string fn, ln, email, password;

                                        //Store user firstname
                                        Console.WriteLine("Enter your First name: ");
                                        fn = Console.ReadLine();
                                        //Store user last name
                                        Console.WriteLine("Enter your First name: ");
                                        ln = Console.ReadLine();
                                        //Store user email
                                        Console.WriteLine("Enter your First name: ");
                                        email = Console.ReadLine();
                                        //Store user password
                                        Console.WriteLine("Enter your First name: ");
                                        password = Console.ReadLine();
                                        _repo.Register(fn,ln,email,password);

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
