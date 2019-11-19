using System;
namespace Shelter.Logic
{
    [Serializable]
    public class Person
    {
        // private fields
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _password;


        /// <summary>
        /// Paramless constructor
        /// </summary>
        public Person()
        {
        }

        /// <summary>
        /// Constructor with all fields
        /// </summary>
        public Person(string first, string last, string email, string password)
        {
            _firstName = first;
            _lastName = last;
            _email = email;
            _password = password;

        }

        /// <summary>
        /// Gets first & lastname and stores to name
        /// </summary>
        public string Name => $"{_firstName} {_lastName}";

        /// <summary>
        /// Set email name. Can't be null
        /// </summary>
        public string Email
        {
            get => _email;
            set => _email = value;
        }


        /// <summary>
        /// Set first name. Can't be null
        /// </summary>
        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }

        /// <summary>
        /// Set Last name. Can't be null
        /// </summary>
        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        public string Password
        {
            get => _password;
            set => _password = value;
        }
    }
}
