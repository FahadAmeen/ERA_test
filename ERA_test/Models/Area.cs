using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ERA_test.Models
{
    //FR044 -- ability to create, modify, disable and delete areas
    public class Area
    {
        [ForeignKey("AreaType")]
        public int AreaTypeId;
        public int Id { get; set; }
        //FR004 --  distinguish the applicable regulations when their geographical borders overlap
        //FR060 -- mandatory property field for defining the overlap priority.
        public int Priority { get; set; }

        //FR058 --mandatory property field for the unique area name
        [Required]
        //TOTO: Apply Unique Constraint as well.
        public string Name { get; set; }

        //FR057 -- mandatory property field for defining the area type
        public AreaType AreaType { get; set; }
        //FR059 -- mandatory property field for linking the applicable regulation reference.
        //FR061 -- mandatory field for linking a minimum of one limit.
        public ICollection<AreaRegulations> Regulations { get; set; }

        //FR062 -- shall be possible to link more then one limit to an area.
        public ICollection<AreaLimits> AreaLimits { get; set; }

        public ICollection<AreaCoordinates> AreaCoordinates { get; set; }
    }
}
