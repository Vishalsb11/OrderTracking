using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace ShippingXam.Models
{
    public class MiscellanousItemDetailsViewModel
    {
        public MiscellanousItemDetails BackOrderGrids { get; set; }

        public MiscellanousItemDetailsViewModel()
        {
            BackOrderGrids = new MiscellanousItemDetails(){ ProductImage = "https://cdn-icons-png.flaticon.com/128/2745/2745060.png", ItemCode = 1047099, Description = "Lidocaine W/EPI Inj MDV 50ml", Ordered = 1, Shipped = 0, BackOrder = 1, Cancelled = 0, NonStock = 0, DropShip = 0 };
        }

        public event PropertyChangingEventHandler PropertyChanged;
        void OnPropertyChange([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                return;
            }
            PropertyChanged.Invoke(this, new PropertyChangingEventArgs(propertyName));
        }
    }
}
