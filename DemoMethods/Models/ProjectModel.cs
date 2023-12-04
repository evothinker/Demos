using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoMethods.Dto;

namespace DemoMethods.Models
{
    public class ProjectModel
    {
        public Employee ProjectMember { get; set; }
        public Equipment ProjectEquipment { get; set; }
        public Property ProjectProperty { get; set; }
    }
}
