using System;
using Serilog;

namespace Shelter.Handler
{


    public class Repo: IRepo, IAnimal
    {


        /// <summary>
        /// Prints title to console
        /// </summary>
        public string ShowTitle()
        {
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


        public void Serialize()
        {


        }


        public void Deserialize()
        {

        }

      
    }
}
