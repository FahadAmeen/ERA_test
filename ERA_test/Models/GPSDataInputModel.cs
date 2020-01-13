using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERA_test.Models
{
    public class GPSDataInputModel
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public float Speed { get; set; }
        public float Direction { get; set; }
    }
}
