using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingXam.Models
{
    public class LoginCredentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Boolean LoginStatus { get; set; }
    }

    public class UserDetails
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public long PhoneNumber { get; set; }
        public DateTime Dob { get; set; }
        public string SetUsername { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
