using System;
using System.Collections.Generic;
using System.Text;

namespace PhotographyStudioManagement.Models
{
    public class Client
    {
        public int ClientID { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public Client()
        {
            Name = "";
            Phone = "";
            Email = "";
        }

        public Client(int clientID, string name, string phone, string email)
        {
            ClientID = clientID;
            Name = name;
            Phone = phone;
            Email = email;
        }

        public string GetClientDetails()
        {
            return $"{Name} - {Phone} - {Email}";
        }
    }
}
