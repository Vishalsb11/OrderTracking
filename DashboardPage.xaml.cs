using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShippingXam.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardPage : ContentPage
    {
        public DashboardPage()
        {
            InitializeComponent();
            //NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Navigate_Track(object sender, EventArgs e)
        {

        }

        private void SearchBar_Dashboard(object sender, EventArgs e)
        {
            
        }

        private async void Navigate_TotalBox(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TotalBoxPage());
        }

        private async void Navigate_Shipped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShippingPage());
        }

        private async void Navigate_Delivered(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DeliveryPage());
        }

        private async void Navigate_MiscellanousItemDetails(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BackOrderPage());
        }

        private async void Navigate_OrderDetails(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderDetailsPage());
        }
    }
}