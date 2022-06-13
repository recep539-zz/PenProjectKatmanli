using Microsoft.EntityFrameworkCore;
using Pen.Entity.Data;

namespace Pen.Dal
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options):base(options)
        {
            
        }     
    }
}