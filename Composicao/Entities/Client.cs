using System;
using System.Collections.Generic;


namespace Composicao.Entities
{
    internal class Client
    {
        public String Name { get; set; }
        public String Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {

        }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            this.BirthDate = birthDate;
        }

        public override string ToString()
        {
            return Name +
                ", (" +
                BirthDate.ToString("dd/MM/yyyy") +
                ") - " + Email;

        }
    }
}
