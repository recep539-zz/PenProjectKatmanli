using System;
using System.Collections.Generic;

namespace Pen.Entity.Data
{
    public partial class PenInformation
    {
        public int Id { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? PenImage { get; set; }
        public string? PenImage1 { get; set; }
        public string? PenImage2 { get; set; }
        public int ProductYear { get; set; }
        public int TipTypeId { get; set; }
        public int FillingMechanismId { get; set; }
        public int CovertypeId { get; set; }
        public int PenStatusId { get; set; }
        public int BodyMaterialId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string? Color { get; set; }
        public int CapLength { get; set; }
        public int PenLengthExcludingCap { get; set; }
        public int CapClosedPenLength { get; set; }
        public int DiameterOfThePen { get; set; }
        public string? Conduction { get; set; }
        public string? Explanation { get; set; }
        public bool Deleted { get; set; }

        public virtual BodyMaterial BodyMaterial { get; set; } = null!;
        public virtual Covertype Covertype { get; set; } = null!;
        public virtual FillingMechanism FillingMechanism { get; set; } = null!;
        public virtual PenStatus PenStatus { get; set; } = null!;
        public virtual TipType TipType { get; set; } = null!;
    }
}
