using System;

namespace ShippingXam.Models
{
    public class BoxDetails
    {
        public int Box { set; get; }
        public long Invoice { set; get; }
        public int WorkOrder { set; get; }
        public string Status { set; get; }
        public int ShippedQuantity { set; get; }
        public DateTime ShipDate { set; get; }
        public long LicensePlate { set; get; }
        public string Tracking { set; get; }
        public string Carrier { set; get; }
    }
}
