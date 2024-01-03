using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace ShippingXam.Models
{
    class OrderDetailsViewModel
    {
        public OrderDetails OrderDetailsGrids { get; set; }

        public OrderDetailsViewModel()
        {
            OrderDetailsGrids = new OrderDetails() { ProductImage = "https://cdn-icons-png.flaticon.com/128/2745/2745060.png", ItemCode = 1047096, Description = "Lidocaine W/EPI Inj MDV 50ml", Ordered = 0, Shipped = 0, BackOrder = 1, Cancelled = 0, NonStock = 0, DropShip = 0 };
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
