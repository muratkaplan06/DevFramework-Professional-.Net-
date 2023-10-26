using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.DataAccess.NHihabernate;
using DevFramework.Core.Entities;

namespace DevFramework.Core.DataAccess.NHibernate
{
    public class NhRepositoryBase<T>:IEntityRepository<T> where T:class, IEntity, new()
    {
        private readonly NHibernateHelper _nHibernateHelper;

        public NhRepositoryBase(NHibernateHelper nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }
        public T Add(T entity)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
               session.Save(entity);
               return entity;
            }
        }

        public void Delete(T entity)
        {
            using (var session=_nHibernateHelper.OpenSession())
            {
                session.Delete(entity);
            }
        }

        public T Get(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
            using (var session=_nHibernateHelper.OpenSession())
            {
                return session.Query<T>().SingleOrDefault(filter);
            }
        }

        public List<T> GetAll(System.Linq.Expressions.Expression<Func<T, bool>> filter = null)
        {
            using (var session=_nHibernateHelper.OpenSession())
            {
              return   filter == null
                    ? session.Query<T>().ToList()
                    : session.Query<T>().Where(filter).ToList();
            }
        }

        public T Update(T entity)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                session.Update(entity);
                return entity;
            }
        }
    }
}
