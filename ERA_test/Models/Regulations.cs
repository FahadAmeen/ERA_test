using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ERA_test.Models
{
    public class Regulations
    {
        public int Id { get; set; }
        //TODO: Unique constraint 
        [Required]
        public string Title { get; set; }
        //[FR054] automated field that contains the timestamp of the last change.
        public DateTime LastChanged { get; set; }

        public ICollection<AreaRegulations> AreaRegulations { get; set; }
    }
}
