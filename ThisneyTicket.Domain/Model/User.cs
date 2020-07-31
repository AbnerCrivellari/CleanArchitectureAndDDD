using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ThisneyTicket.Domain.Model
{
    public class User : Base
    {
        public string Name { get; private set; }
        public string Document { get; private set; }
        public int TypeDocument { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }

        protected User() { }
        public User(string name, string document, int typeDocument, string phone, string email, DateTime birthDate)
        {
            Name = name;
            Document = document;
            TypeDocument = typeDocument;
            Phone = phone;
            Email = email;
            BirthDate = birthDate;
        }
    }
}
