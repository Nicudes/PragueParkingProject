using System;
using System.Collections.Generic;
using System.Text;

namespace PragueParkingProject.Models
{
    public class Staff
    {
        //SÄTT PRIMARYKEY OCH AUTOINCREMENT 1000+1
        public int Id { get; set; }
        public string Stafftype { get; set; }
        public string FirstName { get; set; } // FirstName == password
        public string LastName { get; set; }
        public bool IsWorking { get; set; }

        

    }
}
