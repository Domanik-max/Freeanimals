using System;
namespace Shelter.Handler
{
    interface IRepo
    {

        /// <summary>
        /// Functions shows menu
        /// </summary>
        /// <returns>
        /// Returns string
        /// </returns>
        string ShowTitle();

        /// <summary>
        /// Functions shows customer menu
        /// </summary>
        /// <returns>
        ///  Returns string
        /// </returns>
        string CustomerMenuArt();

        /// <summary>
        /// Functions show admin menu
        /// </summary>
        /// <returns>
        /// Returns string
        /// </returns>
        string AdminMenuArt();

        /// <summary>
        /// Functions that Serializes data
        /// </summary>
       
        void Serialize();

        /// <summary>
        /// Function to deserialize data
        /// </summary>
        void Deserialize();

    }
}
