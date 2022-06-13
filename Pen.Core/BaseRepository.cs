using Microsoft.EntityFrameworkCore;
using Pen.Entity.Data;

namespace Pen.Core
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        PenDbCoreContext _db;
        public BaseRepository(PenDbCoreContext db)
        {
            _db = db;
        }
        public bool Create(T ent)
        {
            try
            {
                Set().Add(ent);
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;

            }
        }

        public bool Delete(T ent)
        {
            try
            {               
                Set().Remove(ent);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }
        }

        public T Find(int id)
        {
            return Set().Find(id);
        }

        public IQueryable<T> Qry()
        {
            return Set().AsQueryable();
        }
        public DbSet<T> Set()
        {
            return _db.Set<T>();
        }

        public bool Update(T ent)
        {
            try
            {
                Set().Update(ent);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }
        }
    }
}