using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShippingXam.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Test2 : ContentPage
	{
		public Test2 ()
		{
			InitializeComponent ();
		}

        private async void GetStarted(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        private async void SignUp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }
    }
}