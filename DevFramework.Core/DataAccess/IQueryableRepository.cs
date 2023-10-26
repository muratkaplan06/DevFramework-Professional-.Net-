using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.DataAccess
{
    public interface IQueryableRepository<T> where T : class, new()
    {
        IQueryable<T> Table { get; }
    }
}
