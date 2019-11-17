using System;
namespace Shelter.Handler
{
    interface IRepo
    {
        /// <summary>
        /// Functions returns a menu
        /// </summary>
        /// <returns>
        /// Returns ASCII art of menu
        /// </returns>
        void customerMenuArt();


        /// <summary>
        /// Functions returns a menu for admin
        /// </summary>
        /// <returns>
        /// Returns ASCII art of menu for admin
        /// </returns>
        void adminMenuArt();




    }
}
