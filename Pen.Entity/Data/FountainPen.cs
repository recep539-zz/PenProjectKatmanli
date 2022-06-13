using System;
using System.Collections.Generic;

namespace Pen.Entity.Data
{
    public partial class FountainPen
    {
        public int Id { get; set; }
        public string? FountainPenTypes { get; set; }
        public bool Deleted { get; set; }
    }
}
