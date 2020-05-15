using PragueParkingProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PragueParkingProject.Services
{
   public class MockStaff
    {


        public List<Staff> allStaff = new List<Staff>
            {
                new Staff
                {
                    Id = 1101,
                    FirstName = "Andre",
                    LastName = "Pontes",
                    Stafftype = "Valet",
                    IsWorking = false
                },
                new Staff
                {
                        Id = 1102,
                    FirstName = "Huy",
                    LastName = "Tran",
                    Stafftype = "Valet",
                    IsWorking = false

                },
                       new Staff
                {
                        Id = 1103,
                    FirstName = "Mattis",
                    LastName = "Vainikainen",
                    Stafftype = "Reception",
                    IsWorking = false

                },
                              new Staff
                {
                        Id = 1104,
                    FirstName = "Daniel",
                    LastName = "Söderberg",
                    Stafftype = "Reception",
                    IsWorking = false

                }

        };
    };
            
            
    
}
