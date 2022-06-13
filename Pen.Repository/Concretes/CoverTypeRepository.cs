using Pen.Core;
using Pen.DTO;
using Pen.Entity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pen.Repository
{
    public class CoverTypeRepository:BaseRepository<Covertype>,ICoverTypeRepository
    {
        public CoverTypeRepository(PenDbCoreContext db) : base(db)
        {

        }

        public IQueryable<CoverTypeList> CoverTypeList()
        {
           return Set().Select(x => new CoverTypeList
            {
                CoverTypeId=x.Id,
                CoverTypeName=x.Covertypes,
                Deleted=x.Deleted
            }).Where(x => x.Deleted == false);
        }

        public IQueryable<CoverTypeList> CoverTypeRecoverList()
        {
            return Set().Select(x => new CoverTypeList
            {
                CoverTypeId = x.Id,
                CoverTypeName = x.Covertypes,
                Deleted = x.Deleted
            }).Where(x => x.Deleted == true);
        }
    }
}
