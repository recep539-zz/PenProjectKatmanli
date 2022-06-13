using System;
using System.Collections.Generic;

namespace Pen.Entity.Data
{
    public partial class Covertype
    {
        public Covertype()
        {
            PenInformations = new HashSet<PenInformation>();
        }

        public int Id { get; set; }
        public string? Covertypes { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<PenInformation> PenInformations { get; set; }
    }
}
