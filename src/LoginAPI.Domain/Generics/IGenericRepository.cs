using LoginAPI.Domain.Generics.Enum;
using LoginAPI.Domain.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAPI.Domain.Generics
{
    public interface IGenericRepository<T> where T : class
    {
        T Retrieve(int codigo);
        T Insert(T entidade);
        T Update(T entidade);
        void Delete(T entidade);
        QueryPagination<T> List(IQueryable<T> query, int qt, int pg, string sortingField, SortingTypeEnum sortingType);
        IQueryable<T> Query();
    }
}
