using Pen.Core;
using Pen.DTO;
using Pen.Entity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pen.Repository
{
    public class FountainPenRepository:BaseRepository<FountainPen>,IFountainPenRepository
    {
        public FountainPenRepository(PenDbCoreContext db):base(db)
        {

        }

        public IQueryable<FountainPenList> FountainPenList()
        {
            return Set().Select(x => new FountainPenList
            {
                FountainPenId=x.Id,
                FountainPenName=x.FountainPenTypes,
                Deleted=x.Deleted
            }).Where(x => x.Deleted == false);
        }

        public IQueryable<FountainPenList> FountainPenRecoverList()
        {
            return Set().Select(x => new FountainPenList
            {
                FountainPenId = x.Id,
                FountainPenName = x.FountainPenTypes,
                Deleted = x.Deleted
            }).Where(x => x.Deleted == true);
        }
    }
}
