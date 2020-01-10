using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ERA_test.Models
{
    //FR046 -- ability to create, modify, disable and delete  regulation references
    public class AreaRegulations
    {
        [ForeignKey("Regulations")]
        public int RegulationId;
        [ForeignKey("Area")]
        public int AreaId;
        public int Id { get; set; }

        public Area Area { get; set; }
        public Regulations Regulation { get; set; }

    }
}
