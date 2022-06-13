using Pen.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pen.UnitOfWork
{
    public interface IUOW
    {
        IBodyMaterialRepository _bodyRepository { get; }
        ICoverTypeRepository _coverRepository { get; }
        IFillingMechanismRepository _fillingRepository { get; }
        IFountainPenRepository _fountenRepository { get; }
        IPenInformationRepository _peninformationRepository { get; }
        IPenStatusRepository _penstatusRepository { get; }
        ITipTypeRepository _tiptypeRepository { get; }
        void Commit();
        void Dispose();
    }
}
