using PragueParkingProject.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
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


        public void DeleteStaff()
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.DropTable<Staff>();
            }
        }

        public void CreateStaff()
        {
            using(SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Staff>();
                foreach (var staff in allStaff)
                {
                    if (allStaff.Any(a => a.Id == staff.Id))
                    {
                        break;

                    }
                    else
                    {
                        int rowsAdded = conn.Insert(staff);
                        Console.WriteLine($"Rows added: {rowsAdded}");
                    }
                    

                    
                }
            }

        }
    };
            
            
    
}
