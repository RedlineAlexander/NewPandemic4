﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewPandemic4.Models
{
    public class Human
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsSick { get; set; }
        public string Gender { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }
    }
}
