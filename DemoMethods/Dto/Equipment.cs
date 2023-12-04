using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMethods.Dto
{
    public class Equipment
    {
        public string Type { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public DateTime LastInspection { get; set; }

    }
}
