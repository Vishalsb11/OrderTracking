
using Xamarin.Forms;

namespace ShippingXam.Models
{
    public class DashboardViewModel
    {
        public Dashboard ColorStatus { get; set; }
        public DashboardViewModel() 
        {
            ColorStatus = new Dashboard() { Color="null", Message = "Ordered" };
            
            if (ColorStatus.Message == "Ordered")
            {
                ColorStatus.Color = "#064996";
            }
            else if (ColorStatus.Message == "Partially Shipped")
            {
                ColorStatus.Color = "Orange";
            }
            else if (ColorStatus.Message == "Delivered")
            {
                ColorStatus.Color = "Green";
            }
        }
    }
}
