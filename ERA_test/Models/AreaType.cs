using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ERA_test.Models
{
    //FR001
    //FR043 ability to create, modify, disable and delete area types
    public class AreaType
    {
        public int Id { get; set; }
        //TOTO: Apply Unique Constraint as well.
        [Required]
        public string Name { get; set; }
           
        public ICollection<Area> Areas { get; set; }

    }
}
