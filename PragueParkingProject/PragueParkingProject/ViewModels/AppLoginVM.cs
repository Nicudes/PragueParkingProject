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
				PropertyChanged(this, new PropertyChangedEventArgs("Username"));
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
		MockStaff mockstaff = new MockStaff();
		public void OnSubmit()
		{
			if (username == mockstaff.staffValet.FirstName  && password == mockstaff.staffValet.LastName)
			{
				App.Current.MainPage.DisplayAlert("Success", "Logging in as Valet", "OK");
				App.Current.MainPage.Navigation.PushAsync(new ValetMainPage());
				mockstaff.staffValet.IsWorking = true;
				return;
			}
			if (username == mockstaff.staffReception.FirstName && password == mockstaff.staffReception.LastName)
			{
				App.Current.MainPage.DisplayAlert("Success", "Logging in as Reception", "OK");
				App.Current.MainPage.Navigation.PushAsync(new ReceptionMainPage());
				mockstaff.staffReception.IsWorking = true;
				return;
			}
			else
			{
			 App.Current.MainPage.DisplayAlert("Error", "Invalid login", "ok");
			}
		}

	}
}
