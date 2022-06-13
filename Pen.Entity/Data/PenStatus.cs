using System;
using System.Collections.Generic;

namespace Pen.Entity.Data
{
    public partial class PenStatus
    {
        public PenStatus()
        {
            PenInformations = new HashSet<PenInformation>();
        }

        public int Id { get; set; }
        public string? Penstatus1 { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<PenInformation> PenInformations { get; set; }
    }
}
