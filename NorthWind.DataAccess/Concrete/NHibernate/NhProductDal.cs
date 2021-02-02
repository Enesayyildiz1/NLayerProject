using NorthWind.DataAccess.Abstract;
using NorthWind.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : IProductDal
    {
        public void Add(Products entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Products entity)
        {
            throw new NotImplementedException();
        }

        public Products Get(Expression<Func<Products, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Products> GetAll(Expression<Func<Products, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Products entity)
        {
            throw new NotImplementedException();
        }
    }
}
