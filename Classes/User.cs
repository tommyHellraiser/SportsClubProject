using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubProject.Classes
{
    internal class User:Person
    {
        public User(string? name, string? lastname, int phone, string? email, string? role, DateTime birthdate)
        : base(name, lastname, phone, email, role, birthdate)
        {
            
        }

    }
}
