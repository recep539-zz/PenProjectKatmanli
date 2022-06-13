using Pen.Core;
using Pen.DTO;
using Pen.Entity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pen.Repository
{
    public class TipTypeRepository:BaseRepository<TipType>,ITipTypeRepository
    {
        public TipTypeRepository(PenDbCoreContext db):base(db)
        {

        }

        public IQueryable<TipTypeList> TipTypeList()
        {
            return Set().Select(x => new TipTypeList
            {
                TipTypeId=x.Id,
                TipTypePenName=x.TipType1,
                Deleted=x.Deleted
            }).Where(x => x.Deleted == false);
        }

        public IQueryable<TipTypeList> TipTypeRecoverList()
        {
            return Set().Select(x => new TipTypeList
            {
                TipTypeId = x.Id,
                TipTypePenName = x.TipType1,
                Deleted = x.Deleted
            }).Where(x => x.Deleted == true);
        }
    }
}
