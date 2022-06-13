using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pen.DTO
{
    public class CoverTypeList
    {
        public int CoverTypeId { get; set; }
        public string? CoverTypeName { get; set; }
        public bool Deleted { get; set; }
    }
}
