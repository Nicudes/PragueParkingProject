using System;
using System.Collections.Generic;
using System.Text;
 

namespace PragueParkingProject.ViewModels
{
    public class AppLoginVM
    {
		private string firstName;

		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}

		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private string lastName;

		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		private bool isWorking;

		public bool IsWorking
		{
			get { return isWorking; }
			set { isWorking = value; }
		}


	}
}
