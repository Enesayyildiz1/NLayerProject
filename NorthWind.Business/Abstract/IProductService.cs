using NorthWind.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Business.Abstract
{
    public interface IProductService
    {
        public List<Products> GetAll();
        List<Products>  GetProductsByCategory(int categoryId);
        List<Products> GetProductsByName(string name);
        public void Add(Products product);
        public void Update(Products product);
        public void Delete(Products product);
    }
}
