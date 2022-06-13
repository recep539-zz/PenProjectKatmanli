using Pen.Core;
using Pen.DTO;
using Pen.Entity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pen.Repository
{
    public class FillingMechanismRepoasitory:BaseRepository<FillingMechanism>,IFillingMechanismRepository
    {
        public FillingMechanismRepoasitory(PenDbCoreContext db):base(db)
        {

        }

        public IQueryable<FillingMechanismList> FillingMechanismList()
        {
            return Set().Select(x => new FillingMechanismList
            {
                FillingMechanismId=x.Id,
                FillingMechanismName=x.FillingMechanisms,
                Deleted=x.Deleted
            }).Where(x => x.Deleted == false);
        }

        public IQueryable<FillingMechanismList> FillingMechanismRecoverList()
        {
            return Set().Select(x => new FillingMechanismList
            {
                FillingMechanismId = x.Id,
                FillingMechanismName = x.FillingMechanisms,
                Deleted = x.Deleted
            }).Where(x => x.Deleted == true);
        }
    }
}
