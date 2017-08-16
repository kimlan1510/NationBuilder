﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NationBuilder.Models
{
    [Table("Nations")]
    public class Nation
    {
        [Key]
        public int NationId { get; set; }
        public string GovernmentType { get; set; }
        public string EconomyType { get; set; }
        public string Geography { get; set; }
        public string Weath { get; set; }
        public int Population { get; set; }
        public int Food { get; set; }
        public int Happiness { get; set; }
        public int MapId { get; set; }
        public virtual Map Map { get; set; }
        public Nation()
        {
            this.Happiness = 70;
            this.Food = 2;
            this.Population = 2;
        }
    }
}