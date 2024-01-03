using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShippingXam.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TotalBoxPage : ContentPage
	{		
        public TotalBoxPage()
		{
			InitializeComponent ();			
        }
        private void SearchBar_BoxDetails(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new DeliveryPage());
        }
    }
}