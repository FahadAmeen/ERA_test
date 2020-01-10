using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ERA_test.Models
{
    public class AreaLimits
    {
        [ForeignKey("Area")]
        public int AreaId;
        public int Id { get; set; }
        public string Name { get; set; }

        //FR002 -- area limits shall be defined as an upper or lower limit.
        public AreaLimitType LimitType { get; set; }

        //FR007 -- the upper limit of SO2/CO2-ratio shall be user defined
        //FR010 -- the lower pH limit of washwater discharge shall be user defined.
        //FR012 -- the upper Turbidity limit of washwater discharge shall be user defined
        public decimal LimitValue { get; set; }

        //FR064 -- property field for defining the unit
        public string Units { get; set; }

        //FR063  mandatory property field for the applicable regulation reference.
        public Regulations Regulation { get; set; }

        //FR007 -- the upper limit of SO2/CO2-ratio shall be user defined

        //FR010 -- the lower pH limit of washwater discharge shall be user defined.


        //FR012 -- the upper Turbidity limit of washwater discharge shall be user defined

        // Need a method to assign Data to the current Object
        // public void SetLimit (Object value){}
        public void SetLimit(decimal value)
        {
            Name = "Turbidity limits";
            LimitValue = value;
            LimitType = AreaLimitType.Upper;
            //FR068 Turbidity limits shall use the unit FNU.
            Units = "FNU";
        }
    }
}
