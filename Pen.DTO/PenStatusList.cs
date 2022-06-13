using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pen.DTO
{
    public class PenStatusList
    {
        public int PenStatusId { get; set; }
        public string? PenStatusName { get; set; }
        public bool Deleted { get; set; }
    }
}
