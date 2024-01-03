using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace ShippingXam.Models
{
    public class BoxDetailsViewModel
    {
        public BoxDetails TotalBoxGrids { get; set; }
        public BoxDetails ShippingGrids { get; set; }
        public BoxDetails DeliveryGrids { get; set; }
        public BoxDetailsViewModel()
        {
            TotalBoxGrids = new BoxDetails() { Box = 1, Invoice = 23244344, WorkOrder = 1, Status = "Shipped", ShippedQuantity = 4, ShipDate = new DateTime(2022, 11, 22), LicensePlate = 985785585, Tracking = "1Z1X10330383094463", Carrier = "UPS" };

            ShippingGrids = new BoxDetails() { Box = 2, Invoice = 23244344, WorkOrder = 1, Status = "Shipped", ShippedQuantity = 4, ShipDate = new DateTime(2022, 11, 22), LicensePlate = 985785585, Tracking = "1Z1X10330383094463", Carrier = "UPS" };

            DeliveryGrids = new BoxDetails() { Box = 3, Invoice = 23244344, WorkOrder = 1, Status = "Shipped", ShippedQuantity = 4, ShipDate = new DateTime(2022, 11, 22), LicensePlate = 985785585, Tracking = "1Z1X10330383094463", Carrier = "UPS" };
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
