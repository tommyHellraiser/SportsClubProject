using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubProject.Classes
{
    internal class Person
    {
        private string? name;
        private string? lastname;
        private string? pass;
        private string? phone;
        private string? email;
        private string? role;
        private DateTime birthdate;

        public Person (string name, string lastname, string pass, string phone, string email, 
            string role, DateTime birthdate)
        {
            this.name = name;
            this.lastname = lastname;
            this.Pass = pass;
            this.phone = phone;
            this.email = email;
            this.role = role;
            this.birthdate = birthdate;
        }

        /// <summary>
        /// Constructor overload, to allow login without having to define unknown parameters
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pass"></param>
        public Person(string name, string pass)
        {
            this.name = name;
            this.pass = pass;
        }

        public string? Name { get => name; set => name = value; }
        public string? Lastname { get => lastname; set => lastname = value; }
        public string? Pass { get => pass; set => pass = value; }

        public string Phone { get => phone; set => phone = value; }
        public string? Email { get => email; set => email = value; }
        public string? Role { get => role; set => role = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }
    }
}
