﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task4.Models
{
    public class Profile
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Age { get; set; }
        public string Qualification { get; set; }
        public bool ISEmployed { get; set; }
        public int NoticePeriod { get; set; }
        public double CurrentCTC { get; set; }
    }
}
