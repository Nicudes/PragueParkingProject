using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PragueParkingProject.Models;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PragueParkingProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegNewCustomer : ContentPage
    {
        public RegNewCustomer()
        {
            InitializeComponent();
        }

        private void saveButton_Clicked(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                FirstName = nameEntry.Text
            };
            using(SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Customer>();
                conn.Insert(customer);
            }
        }
    }
}