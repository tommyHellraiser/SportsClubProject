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
        private int phone;
        private string? email;
        private string? role;
        private DateTime birthdate;

        public Person (string? name, string? lastname, int phone, string? email, string? role, DateTime birthdate)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Phone = phone;
            this.Email = email;
            this.Role = role;
            this.Birthdate = birthdate;
        }

        public string? Name { get => name; set => name = value; }
        public string? Lastname { get => lastname; set => lastname = value; }
        public int Phone { get => phone; set => phone = value; }
        public string? Email { get => email; set => email = value; }
        public string? Role { get => role; set => role = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }
    }
}
