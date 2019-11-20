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

        /// <summary>
        /// To register a user
        /// </summary>
        /// <returns>
        /// Will return user credentials 
        /// </returns>
        void Register(string first, string last, string email, string password);

        /// <summary>
        /// To sign in the user to profile
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        void Signin(string email, string password);


    }
}
