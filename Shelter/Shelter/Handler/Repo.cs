﻿using System;
using Serilog;
using Shelter.Logic;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.IO;
using
using Newtonsoft.Json;

namespace Shelter.Handler
{


    public class Repo: IRepo, IAnimal
    {


        /// <summary>
        /// Prints title to console
        /// </summary>
        public string ShowTitle()
        {
            Log.Information("Start of ShowTitle() Function");
            string title = @"
                      (                            )                    
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
            return title;
        }

        /// <summary>
        /// Prints to console customer menu
        /// </summary>
        public string CustomerMenuArt()
        {
            return @"
                                             *                       
           (               *   )   (  `                      
           )\     (      ` )  /(   )\))(     (           (   
         (((_)   ))\  (   ( )(_)) ((_)()\   ))\  (      ))\  
         )\___  /((_) )\ (_(_())  (_()((_) /((_) )\ )  /((_) 
        ((/ __|(_))( ((_)|_   _|  |  \/  |(_))  _(_/( (_))(  
         | (__ | || |(_-<  | |    | |\/| |/ -_)| ' \))| || | 
          \___| \_,_|/__/  |_|    |_|  |_|\___||_||_|  \_,_| 
                                                     
      ";
        }

        /// <summary>
        /// Prints to cutomer Admin menu
        /// </summary>
        public string AdminMenuArt()
        {
            return @"
                                              *                       
           (      (                        (  `                      
           )\     )\ )    )    (           )\))(     (           (   
        ((((_)(  (()/(   (     )\   (     ((_)()\   ))\  (      ))\  
         )\ _ )\  ((_))  )\  '((_)  )\ )  (_()((_) /((_) )\ )  /((_) 
         (_)_\(_) _| | _((_))  (_) _(_/(  |  \/  |(_))  _(_/( (_))(  
          / _ \ / _` || '  \() | || ' \)) | |\/| |/ -_)| ' \))| || | 
         /_/ \_\\__,_||_|_|_|  |_||_||_|  |_|  |_|\___||_||_|  \_,_| 
       ";
        }



        /// <summary>
        /// To register the person 
        /// </summary>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
       
        public void Register(string first, string last, string email, string password)
        {
            var newPerson = new Person
            {
                FirstName = first,
                LastName = last,
                Email = email,
                Password = password
            };

           
        }
        
        public void Signin(string email, string password)
        {
            
        }


        public void Serialize(string text,FileStream fileName)
        { 
            var writer = new StreamWriter(fileName);

            string json = JsonConvert.

            writer.Write(text);
            writer.Close();
        }


        public void Deserialize()
        {

        }

      
    }
}
