﻿using System;
using System.Collections.Generic;

namespace VegetablesOnlineShop.Models
{
    public partial class Location
    {
        public Location()
        {
            Customers = new HashSet<Customer>();
        }

        public int LocationId { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? NameWithType { get; set; }
        public string? PathWithType { get; set; }
        public int? Levels { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
