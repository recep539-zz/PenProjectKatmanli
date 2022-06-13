using Pen.Core;
using Pen.DTO;
using Pen.Entity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pen.Repository
{
    public class PenStatusRepository:BaseRepository<PenStatus>,IPenStatusRepository
    {
        public PenStatusRepository(PenDbCoreContext db):base(db)
        {

        }

        public IQueryable<PenStatusList> PenStatusList()
        {
            return Set().Select(x => new PenStatusList
            {
                PenStatusId=x.Id,
                PenStatusName=x.Penstatus1,
                Deleted=x.Deleted
            }).Where(x => x.Deleted == false);
        }

        public IQueryable<PenStatusList> PenStatusRecoverList()
        {
            return Set().Select(x => new PenStatusList
            {
                PenStatusId = x.Id,
                PenStatusName = x.Penstatus1,
                Deleted = x.Deleted
            }).Where(x => x.Deleted == true);
        }
    }
}
