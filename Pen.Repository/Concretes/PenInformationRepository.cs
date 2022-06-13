using Microsoft.AspNetCore.Http;
using Pen.Core;
using Pen.DTO;
using Pen.Entity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pen.Repository
{
    public class PenInformationRepository : BaseRepository<PenInformation>, IPenInformationRepository
    {
        public PenInformationRepository(PenDbCoreContext db) : base(db)
        {

        }

        public IQueryable<PenInformationList> PenInformationDetailList(int id)
        {
            return Set().Where(x=>x.Id==id && x.Deleted == false).Select(x => new PenInformationList
            {             
                PenImage =x.PenImage,
                PenImage1=x.PenImage1,
                PenImage2=x.PenImage2,
                Brand = x.Brand,
                Model = x.Model,
                ProductYear = x.ProductYear,
                PurchaseDate = x.PurchaseDate,
                Color = x.Color,
                CapLength = x.CapLength,
                PenLengthExcludingCap = x.PenLengthExcludingCap,
                CapClosedPenLength = x.CapClosedPenLength,
                DiameterOfThePen = x.DiameterOfThePen,
                Conduction = x.Conduction,
                PenStatusName = x.PenStatus.Penstatus1,
                Explanation = x.Explanation,
                tipTypes = x.TipType.TipType1,
                covertype = x.Covertype.Covertypes,
                fillingMechanism = x.FillingMechanism.FillingMechanisms,
                BodyMaterial = x.BodyMaterial.Bodymaterial1,
                Deleted = x.Deleted
            });
        }

        public IQueryable<PenInformationList> PenInformationList()
        {
            return Set().Select(x => new PenInformationList
            {
                PenInformationId = x.Id,
                PenImage = x.PenImage,
                PenImage1 = x.PenImage1,
                PenImage2 = x.PenImage2,
                Brand = x.Brand,
                Model = x.Model,
                ProductYear = x.ProductYear,
                PurchaseDate = x.PurchaseDate,
                Color = x.Color,
                CapLength = x.CapLength,
                PenLengthExcludingCap = x.PenLengthExcludingCap,
                CapClosedPenLength = x.CapClosedPenLength,
                DiameterOfThePen = x.DiameterOfThePen,
                Conduction = x.Conduction,
                PenStatusName = x.PenStatus.Penstatus1,
                Explanation = x.Explanation,
                tipTypes = x.TipType.TipType1,
                covertype = x.Covertype.Covertypes,
                fillingMechanism = x.FillingMechanism.FillingMechanisms,
                BodyMaterial = x.BodyMaterial.Bodymaterial1,
                Deleted = x.Deleted
            }).Where(x => x.Deleted == false);
        }

        public IQueryable<PenInformationList> PenInformationRecoverList()
        {
            return Set().Select(x => new PenInformationList
            {
                PenInformationId = x.Id,
                PenImage = x.PenImage,
                PenImage1 = x.PenImage1,
                PenImage2 = x.PenImage2,
                Brand = x.Brand,
                Model = x.Model,
                ProductYear = x.ProductYear,
                PurchaseDate = x.PurchaseDate,
                Color = x.Color,
                CapLength = x.CapLength,
                PenLengthExcludingCap = x.PenLengthExcludingCap,
                CapClosedPenLength = x.CapClosedPenLength,
                DiameterOfThePen = x.DiameterOfThePen,
                Conduction = x.Conduction,
                PenStatusName = x.PenStatus.Penstatus1,
                Explanation = x.Explanation,
                tipTypes = x.TipType.TipType1,
                covertype = x.Covertype.Covertypes,
                fillingMechanism = x.FillingMechanism.FillingMechanisms,
                BodyMaterial = x.BodyMaterial.Bodymaterial1,
                Deleted = x.Deleted
            }).Where(x => x.Deleted == true);
        
       
        }
    }
}
