using System;
using System.Collections.Generic;

namespace Pen.Entity.Data
{
    public partial class BodyMaterial
    {
        public BodyMaterial()
        {
            PenInformations = new HashSet<PenInformation>();
        }

        public int Id { get; set; }
        public string? Bodymaterial1 { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<PenInformation> PenInformations { get; set; }
    }
}
