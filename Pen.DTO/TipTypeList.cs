using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pen.DTO
{
    public class TipTypeList
    {
        public int TipTypeId { get; set; }
        public string? TipTypePenName { get; set; }
        public bool Deleted { get; set; }
    }
}
