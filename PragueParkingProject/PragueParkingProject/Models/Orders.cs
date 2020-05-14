using System;
using System.Collections.Generic;
using System.Text;

namespace PragueParkingProject.Models
{
    public class Orders
    {
        //PRIMARYKEY + AUTOINC
        public int Id { get; set; }

        //FK till customer ID
        public int CustId { get; set; }

        //FK till staff/valet
        public int ValetId { get; set; }

        public string ParkingSpot { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal HourlyFee { get; set; }
        public bool IsActive { get; set; }


    }
}
