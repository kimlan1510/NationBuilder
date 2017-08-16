using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NationBuilder.Models
{
    [Table("Maps")]
    public class Map
    {
        [Key]
        public int MapId { get; set; }
        public string Name { get; set; }
        public int Food { get; set; }
        public int Resources { get; set; }
        public ICollection<Nation> Nations { get; set; }
        public Map()
        {
            this.Food = 3600;
            this.Resources = 7200;
        }
    }
}
