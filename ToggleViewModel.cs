using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingXam.Models
{
    class ToggleViewModel
    {
        public Switch1 toggle_1 { get; set; }
        public Switch2 toggle_2 { get; set; }
        public Switch3 toggle_3 { get; set; }

        public ToggleViewModel()
        {
            toggle_1 = new Switch1() { Status = false, Chooser = "Select" };
            toggle_2 = new Switch2() { Status = false, Chooser = "Select" };
            toggle_3 = new Switch3() { Status = false, Chooser = "Select" };

            if((toggle_1.Chooser=="Select") && (toggle_1.Status == false))
            {
                toggle_1.Status = true;
                toggle_2.Chooser = "Deselect";
                toggle_3.Chooser = toggle_2.Chooser;
            }

            if ((toggle_2.Chooser == "Select") && (toggle_2.Status == false))
            {
                toggle_2.Status = true;
                toggle_3.Chooser = "Deselect";
                toggle_1.Chooser = toggle_3.Chooser;
            }
            else if ((toggle_2.Chooser == "Deselect"))
            {
                toggle_2.Status = false;
            }

            if ((toggle_3.Chooser == "Select") && (toggle_3.Status == false))
            {
                toggle_3.Status = true;
                toggle_1.Chooser = "Deselect";
                toggle_2.Chooser = toggle_1.Chooser;
            }
            else if ((toggle_3.Chooser == "Deselect"))
            {
                toggle_3.Status = false;
            }
        }
    }
}
