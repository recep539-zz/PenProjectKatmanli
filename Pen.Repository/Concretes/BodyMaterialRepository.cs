using Pen.Core;
using Pen.DTO;
using Pen.Entity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pen.Repository
{
    public class BodyMaterialRepository : BaseRepository<BodyMaterial>, IBodyMaterialRepository
    {
        public BodyMaterialRepository(PenDbCoreContext db) : base(db)
        {

        }

        public IQueryable<BodyMaterialList> BodyList()
        {
            return Set().Select(x => new BodyMaterialList
            {
                BodyMaterialId = x.Id,
                BodyMaterialName = x.Bodymaterial1,
                Deleted = x.Deleted
            }).Where(x => x.Deleted == false);
        }
        public IQueryable<BodyMaterialList> BodyRecoverList()
        {
            return Set().Select(x => new BodyMaterialList
            {
                BodyMaterialId = x.Id,
                BodyMaterialName = x.Bodymaterial1,
                Deleted = x.Deleted
            }).Where(x => x.Deleted == true);
        }
    }
}
