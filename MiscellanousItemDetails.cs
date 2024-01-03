using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ShippingXam.Models
{
    public class MiscellanousItemDetails
    {
        public ImageSource ProductImage { get; set; }
        public long ItemCode { get; set; }
        public string Description { get; set; }
        public int Ordered { get; set; }
        public int Shipped { get; set; }
        public int BackOrder { get; set; }
        public int Cancelled { get; set; }
        public int NonStock { get; set; }
        public int DropShip { get; set; }
    }
}
