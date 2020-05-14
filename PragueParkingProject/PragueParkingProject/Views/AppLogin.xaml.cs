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
    public partial class AppLogin : ContentPage
    {
        public AppLogin()
        {
            InitializeComponent();

            AppUserName.Text = Id.ToString();
            AppPassword.Text = Services.MockStaff;
        }


        private void LoginButton_Clicked(object sender, EventArgs e)
        {

        }

    }
}