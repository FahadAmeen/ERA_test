using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ERA_test.Models
{
    //FR002 -- area limits shall be defined as an upper or lower limit.
    public enum AreaLimitType
    {
        [Description("Lower Limit")]
        Lower = 0,
        [Description("Upper Limit")]
        Upper = 1,
    }
}
