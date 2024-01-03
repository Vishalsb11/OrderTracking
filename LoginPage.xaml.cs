using ShippingXam.Models; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShippingXam.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            LoginCredentialsViewModel Credentials = new LoginCredentialsViewModel();
            InitializeComponent();
            BindingContext = Credentials.loginProcess;
        }

        private async void RedirectLogin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DashboardPage());
        }

        //private async void Navigate_RememberMe(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new DashboardPage());
        //}

        private async void Navigate_ForgotPassword(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DashboardPage());
        }

        private async void Navigate_SignUp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }
    }
}