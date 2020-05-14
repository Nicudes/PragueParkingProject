using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using PragueParkingProject.Views;
using PragueParkingProject.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.ComponentModel;
using PragueParkingProject.Services;

namespace PragueParkingProject.ViewModels
{
    public class AppLoginVM :INotifyPropertyChanged
    {
		public event PropertyChangedEventHandler PropertyChanged;

		private string username;

		public string Username
		{
			get { return username; }
			set { username = value;
				PropertyChanged(this, new PropertyChangedEventArgs("Username")); //För att rutan ska reagera när du skriver in något 
			}
		}

		private string password;

		

		public string Password
		{
			get { return password; }
			set { password = value;
				PropertyChanged(this, new PropertyChangedEventArgs("Password"));
			}
		}

		public ICommand SubmitCommand {get; set; }
		public AppLoginVM()
		{
			SubmitCommand = new Command(OnSubmit);
		}


		public Staff currentStaff = new Staff() // För att kolla vilken person som jobbar just nu----Kanske kan lägga någon annan stans
		{
			FirstName = "",
			LastName = "",
			Id = 0,
			IsWorking = false,
			Stafftype = ""
			
		};


		MockStaff mockstaff = new MockStaff(); // Hämtar mockstaff

		bool isAuthenticated = false; // för att hantera utloggning sen möjligtvis

		public void OnSubmit() // När vi trycker login så körs detta
		{
			foreach (var staff in mockstaff.allStaff) // Loopar igenom allStaff listan som skapats i mockstaff
			{
				if (username == staff.FirstName && password == staff.LastName) // om den hittar någon som matchar så gå den in här
				{
					if (staff.Stafftype == "Valet") 
					{
						App.Current.MainPage.DisplayAlert("Success", "Logging in as Valet", "OK");
						App.Current.MainPage.Navigation.PushAsync(new ValetMainPage());
						staff.IsWorking = true;
						isAuthenticated = true;

						//sätter currentstaff för att hantera orders osv senare
						currentStaff.FirstName = staff.FirstName;
						currentStaff.LastName = staff.LastName;
						currentStaff.Id = staff.Id;
						currentStaff.IsWorking = staff.IsWorking;
						currentStaff.Stafftype = staff.Stafftype;

						return;
					}
					if (staff.Stafftype == "Reception")
					{
						App.Current.MainPage.DisplayAlert("Success", "Logging in as Reception", "OK");
						App.Current.MainPage.Navigation.PushAsync(new ReceptionMainPage());
						staff.IsWorking = true;
						isAuthenticated = true;

						currentStaff.FirstName = staff.FirstName;
						currentStaff.LastName = staff.LastName;
						currentStaff.Id = staff.Id;
						currentStaff.IsWorking = staff.IsWorking;
						currentStaff.Stafftype = staff.Stafftype;

						return;
					}
				}

			}
			if (isAuthenticated == false)
			{
				App.Current.MainPage.DisplayAlert("Error", "Could not find a user with that login", "OK");

			}

		}

	}
}
