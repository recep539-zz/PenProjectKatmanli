using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pen.DTO
{
    public class PenInformationList
    {
        public int PenInformationId { get; set; }
        public string? PenImage { get; set; }
        public string? PenImage1 { get; set; }
        public string? PenImage2 { get; set; }
        public bool Deleted { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int ProductYear { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string? Color { get; set; }
        public int CapLength { get; set; }
        public int PenLengthExcludingCap { get; set; }
        public int CapClosedPenLength { get; set; }
        public int DiameterOfThePen { get; set; }
        public string? Conduction { get; set; }
        public string? Explanation { get; set; }
        public string? tipTypes { get; set; }
        public string? fillingMechanism { get; set; }
        public string? covertype { get; set; }
        public string? PenStatusName { get; set; }
        public string? BodyMaterial { get; set; }
    }
}
