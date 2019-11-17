using System;
namespace Shelter.Handler
{
    public class Repo: IRepo
    {

        /// <summary>
        /// Prints to console customer menu
        /// </summary>
        public void customerMenuArt()
        {
            Console.WriteLine(@"
                                             *                       
           (               *   )   (  `                      
           )\     (      ` )  /(   )\))(     (           (   
         (((_)   ))\  (   ( )(_)) ((_)()\   ))\  (      ))\  
         )\___  /((_) )\ (_(_())  (_()((_) /((_) )\ )  /((_) 
        ((/ __|(_))( ((_)|_   _|  |  \/  |(_))  _(_/( (_))(  
         | (__ | || |(_-<  | |    | |\/| |/ -_)| ' \))| || | 
          \___| \_,_|/__/  |_|    |_|  |_|\___||_||_|  \_,_| 
                                                     
      ");
        }

        /// <summary>
        /// Prints to cutomer Admin menu
        /// </summary>
        public void adminMenuArt()
        {
            Console.WriteLine(@"
                                              *                       
           (      (                        (  `                      
           )\     )\ )    )    (           )\))(     (           (   
        ((((_)(  (()/(   (     )\   (     ((_)()\   ))\  (      ))\  
         )\ _ )\  ((_))  )\  '((_)  )\ )  (_()((_) /((_) )\ )  /((_) 
         (_)_\(_) _| | _((_))  (_) _(_/(  |  \/  |(_))  _(_/( (_))(  
          / _ \ / _` || '  \() | || ' \)) | |\/| |/ -_)| ' \))| || | 
         /_/ \_\\__,_||_|_|_|  |_||_||_|  |_|  |_|\___||_||_|  \_,_| 
       ");
        }
    }
}
