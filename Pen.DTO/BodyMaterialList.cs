using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pen.DTO
{
    public class BodyMaterialList
    {
        public int BodyMaterialId { get; set; }
        public string? BodyMaterialName { get; set; }
        public bool Deleted { get; set; }
    }
}
