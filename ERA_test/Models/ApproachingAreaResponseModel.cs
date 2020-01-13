using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERA_test.Models
{
    public class ApproachingAreaResponseModel
    {
        public string Name { get; set; }
        public string AreaType { get; set; }
        public AreaLimits CompliancyLimits { get; set; }
        public bool OpenLoopAllowed { get; set; }
        public bool PreNotification { get; set; }
        public TimeSpan TimeToBorder { get; set; }
        public long DistanceToBorder { get; set; }
        public double VesselDirection { get; set; }
        public double VesselSpeed { get; set; }
    }
}
