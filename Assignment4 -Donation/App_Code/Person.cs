using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for Person
/// </summary>
public class Person
{
   		public string FirstName{set; get;}
        public string LastName { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }
        public string Apartment { set; get; }
        public string State { set; get; }
        public string Zipcode { set; get; }
        public string Password { set; get; }
        public int Passcode { set; get; }
        public string DonationDate { set; get; }
        public string DonationAmount { set; get; }
        public string PlainPassword { get; set; }
        public Byte[] PasswordHash { set; get; }
}