﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Entities.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        public int CountryId { get; set; }
        public string CityName { get; set; }
    }
}
