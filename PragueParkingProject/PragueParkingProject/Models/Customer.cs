using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PragueParkingProject.Models
{
    public class Customer
    {
        //SÄTT PRIMARYKEY OCH AUTOINCREMENT
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public bool MonthlyCustomer { get; set; }
        public string RegistrationNumber { get; set; }
        public string SocialSecurityNumber { get; set; }



    }
}
