using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ERA_test.Models
{
    public class AreaCoordinates
    {
        [ForeignKey("Area")]
        public int AreaId;
        public long Id { get; set; }

        //FR048 --The ERA Updater shall be able to import geographical data in the Decimal Degree format.

        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        //public NpgsqlPoint Point { get; set; } // This Can be a POSTGIS geography point
        public Area Area { get; set; }
    }
}
