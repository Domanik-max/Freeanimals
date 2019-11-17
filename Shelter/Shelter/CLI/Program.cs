using System;
using Shelter.Handler;
using Serilog;


namespace Shelter.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Injecting class that contains all methods 
            Repo _repo = new Repo();

            //Keep track of answers
            string ans;
            string title = @"
                     (                           )                    
             )\ )            (        ( /(                    
            (()/(           ))\       )\())               (   
             /(_))   (     (((_) (   ((_)\   (   `  )    ))\  
            (_))_    )\    )\  ' )\   _((_)  )\  /(/(   /((_) 
             |   \  ((_) _((_)) ((_) | || | ((_)((_)_\ (_))   
             | |) |/ _ \| '  \()(_-< | __ |/ _ \| '_ \)/ -_)  
             |___/ \___/|_|_|_| /__/ |_||_|\___/| .__/ \___|  
                                                |_|           

                Press [1]: Customer
                Press [2]: Admin
                                                          ";


            //Start of Console Application
            while (true)
            {
               //Printing main menu to console
               Console.WriteLine(title);
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
                                _repo.customerMenuArt();
                                Console.WriteLine("It Continued");
                                break;
                            // Admin Menu
                            case 2:
                                _repo.adminMenuArt();
                                break;


                        }

                    }
                    // Base exception
                    catch (Exception e)
                    {
                        Console.WriteLine("You entered Wrong Input! Try again");
                        continue;
                    }




                }
                break;
            }

            Console.WriteLine("Out of loop");
        }
    }
}
