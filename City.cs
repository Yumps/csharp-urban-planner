using System;
using System.Collections.Generic;

namespace csharp_urban_planner
{
    public class City
    {
        public string Name { get; set; }
        public string Mayor { get; set; }
        public int Year { get; set; }
        public List<Building> Buildings = new List<Building>();
    }
}