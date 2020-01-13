using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERA_test.Models
{
    public class CurrentAreaResponseModel
    {
        public string Name { get; set; }
        public string AreaType { get; set; }
        public AreaLimits CompliancyLimits { get; set; }
        public bool OpenLoopAllowed { get; set; }
        public bool CrossedBorder { get; set; }
        public string LastAreaName { get; set; }
    }
}
