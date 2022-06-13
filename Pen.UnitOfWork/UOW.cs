using Pen.Entity.Data;
using Pen.Repository;

namespace Pen.UnitOfWork
{
    public class UOW : IUOW
    {
        PenDbCoreContext _db;
        public UOW(PenDbCoreContext db)
        {
            _db = db;
            _bodyRepository = new BodyMaterialRepository(db);
            _coverRepository = new CoverTypeRepository(db);
            _fillingRepository = new FillingMechanismRepoasitory(db);
            _fountenRepository = new FountainPenRepository(db);
            _peninformationRepository = new PenInformationRepository(db);
            _penstatusRepository = new PenStatusRepository(db);
            _tiptypeRepository = new TipTypeRepository(db);
        }
        public IBodyMaterialRepository _bodyRepository { get; private set; }

        public ICoverTypeRepository _coverRepository { get; private set; }

        public IFillingMechanismRepository _fillingRepository { get; private set; }

        public IFountainPenRepository _fountenRepository { get; private set; }

        public IPenInformationRepository _peninformationRepository { get; private set; }

        public IPenStatusRepository _penstatusRepository { get; private set; }

        public ITipTypeRepository _tiptypeRepository { get; private set; }

        public void Commit()
        {
            _db.SaveChanges();
        }

        public void Dispose()
        {
           _db.Dispose();
        }
    }
}