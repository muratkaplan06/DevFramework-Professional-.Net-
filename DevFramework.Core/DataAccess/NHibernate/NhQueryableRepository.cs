using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.DataAccess.NHihabernate;

namespace DevFramework.Core.DataAccess.NHibernate
{
    public class NhQueryableRepository<T>:IQueryableRepository<T> where T:class, new()
    {
        private readonly NHibernateHelper _nHibernateHelper;
        private  IQueryable<T> _entities;

        public NhQueryableRepository(NHibernateHelper nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public IQueryable<T> Table
        {
            get
            {
                return this.Entities;
            }
        }

        public virtual IQueryable<T> Entities
        {
            get
            {
                return _entities ?? (_entities = _nHibernateHelper.OpenSession().Query<T>());
            }
        }
    }
}
