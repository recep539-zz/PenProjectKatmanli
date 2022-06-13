using Pen.Core;
using Pen.DTO;
using Pen.Entity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Pen.Repository
{
    public interface IPenInformationRepository : IBaseRepository<PenInformation>
    {
        IQueryable<PenInformationList> PenInformationList();
        IQueryable<PenInformationList> PenInformationRecoverList();
        IQueryable<PenInformationList> PenInformationDetailList(int id);
    }
}
