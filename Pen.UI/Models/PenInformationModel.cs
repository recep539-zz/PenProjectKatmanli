using Pen.DTO;
using Pen.Entity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pen.UI.Models
{
    public class PenInformationModel
    {
        public PenInformation PenInformation { get; set; }
        public string? Title { get; set; }
        public string? BtnClass { get; set; }
        public string? BtnVal { get; set; }
        public IQueryable<TipTypeList> TipTypeList { get; set; }
        public IQueryable<FillingMechanismList> FillingMechanismList { get; set; }
        public IQueryable<BodyMaterialList> BodyMaterialList { get; set; }
        public IQueryable<PenStatusList> PenStatusList { get; set; }
        public IQueryable<CoverTypeList> CoverTypeList { get; set; }
    }
}
