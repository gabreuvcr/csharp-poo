using System;

namespace Shopping.Entities 
{
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            string text = $"{Name} ({BirthDate.ToString("dd/MM/yyyy")}) - {Email}";

            return text;
        }
    }

}
