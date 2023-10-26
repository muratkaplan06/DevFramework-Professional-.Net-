using System.Data.Entity;
using System.Linq;

namespace DevFramework.Core.DataAccess.EntityFramework
{
    public class EfQueryableRepository<T>:IQueryableRepository<T> where T:class,new()
    {
        private DbContext _context;

        private IDbSet<T> _entities;

        public EfQueryableRepository(DbContext context)
        {
            _context = context;
        }

        public IQueryable<T> Table => this._entities;
        protected virtual IDbSet<T> Entities => _entities ?? (_entities = _context.Set<T>());
    }
}
