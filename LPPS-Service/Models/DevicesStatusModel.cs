using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LPPS_Service.Models
{
    public class DevicesStatusModel
    {
        public bool ControlBoard { get; set; }
        public bool FlowSpeedMeter{ get; set; }
        public bool Cylinder_X { get; set; }
        public bool Cylinder_Y { get; set; }

    }
}
