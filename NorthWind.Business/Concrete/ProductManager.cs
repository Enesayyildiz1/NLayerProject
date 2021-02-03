using NorthWind.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWind.DataAccess.Concrete.EntityFramework;
using NorthWind.DataAccess.Abstract;
using NorthWind.Business.Abstract;

namespace NorthWind.Business.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        EfProductDal EfProductDal = new EfProductDal();

        public List<Products> GetAll()
        {
            
            return EfProductDal.GetAll();
        }
    }
}
