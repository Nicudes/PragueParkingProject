using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using PragueParkingProject.Views;
using PragueParkingProject.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.ComponentModel;

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

		public void OnSubmit()
		{
			if (username == "Andre" && password == "Pontes")
			{
				App.Current.MainPage.DisplayAlert("YES", "Login Success", "ok");
				App.Current.MainPage.Navigation.PushAsync(new SecondMainPage());
			}
			else
			{
			 App.Current.MainPage.DisplayAlert("Error", "Invalid login", "ok");
			}
		}

	}
}
