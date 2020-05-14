using PragueParkingProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PragueParkingProject.Services
{
    public class MockStaff
    {
        Staff staffValet = new Staff()
        {
            FirstName = "Rodrigo",
            Id = 1001,
            LastName = "Dude",
            IsWorking = false
        };

        Staff staffReception = new Staff()
        {
            FirstName = "Gunilla",
            Id = 1002,
            LastName = "Hope",
            IsWorking = true
        };

    }
}
