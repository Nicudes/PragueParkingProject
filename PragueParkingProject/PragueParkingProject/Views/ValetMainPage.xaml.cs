using PragueParkingProject.Models;
using PragueParkingProject.Services;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PragueParkingProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ValetMainPage : ContentPage
    {
        public ValetMainPage()
        {
            InitializeComponent();
            MockStaff ms = new MockStaff();

            ms.CreateStaff();

            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Staff>();
                var staff = conn.Table<Staff>().ToList();

                AllStaffListView.ItemsSource = staff;
            }
        }

        private void MyOrdersButton_Clicked(object sender, EventArgs e)
        {

        }

        private void ActiveordersButton_Clicked(object sender, EventArgs e)
        {

        }

        private void LogOutButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}