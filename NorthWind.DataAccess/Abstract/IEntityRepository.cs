using NorthWind.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class,new()
    {
        public List<T > GetAll(Expression<Func<T,bool>> filter=null);
        public T Get(Expression<Func<T, bool>> filter);
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(T entity);
    }
}
