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
        private string? username;
        private string? firstName;
        private string? lastName;
        private string? pass;
        private string? phone;
        private string? email;
        private string? role;
        private DateTime birthDate;

        public Person (string firstName, string lastName, string pass, string phone, string email, 
            string role, DateTime birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.pass = pass;
            this.phone = phone;
            this.email = email;
            this.role = role;
            this.birthDate = birthDate;
        }

        public Person(string name, string pass)
        {
            this.firstName = name;
            this.pass = pass;
        }

        public Person()
        {

        }

        public string? Username { get => username; set => username = value; }
        public string? FirstName { get => firstName; set => firstName = value; }
        public string? LastName { get => lastName; set => lastName = value; }
        public string? Pass { get => pass; set => pass = value; }

        public string? Phone { get => phone; set => phone = value; }
        public string? Email { get => email; set => email = value; }
        public string? UserRole { get => role; set => role = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
	}
}
