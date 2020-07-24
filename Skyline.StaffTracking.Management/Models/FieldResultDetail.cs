using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyline.StaffTracking.Management
{
    public class FieldResultDetail
    {
        public int RestaurantFieldId { get; set; }
        public bool FieldResult { get; set; }
        public string Distance { get; set; }
        public string Comment { get; set; }
        public DateTime DateCreated { get; set; }
        public string AttachPath { get; set; }
    }
}
