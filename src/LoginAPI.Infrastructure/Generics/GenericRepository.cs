using LoginAPI.Domain.Generics;
using LoginAPI.Domain.Generics.Enum;
using LoginAPI.Domain.Util;
using NHibernate;

namespace LoginAPI.Infrastructure.Generics
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ISession session;

        public GenericRepository(ISession session)
        {
            this.session = session;
        }
        public void Delete(T entidade)
        {
            session.Delete(entidade);
        }

        public T Insert(T entidade)
        {
            session.Save(entidade);
            return entidade;
        }

        public QueryPagination<T> List(IQueryable<T> query, int qt, int pg, string sortingField, SortingTypeEnum sortingType)
        {
            return new QueryPagination<T>
            {
                Records = query.Skip((pg - 1) * qt).Take(qt).ToList(),
                Total = query.LongCount()
            };
        }

        public IQueryable<T> Query()
        {
            return session.Query<T>();
        }

        public T Retrieve(int id)
        {
            return session.Get<T>(id);
        }

        public T Update(T entidade)
        {
            session.Update(entidade);
            return entidade;
        }
    }
}
