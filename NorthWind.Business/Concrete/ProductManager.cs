using NorthWind.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWind.DataAccess.Concrete.EntityFramework;
using NorthWind.DataAccess.Abstract;
using NorthWind.Business.Abstract;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;

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

        public List<Products> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(x => x.CategoryID == categoryId).ToList();
        }

        public List<Products> GetProductsByName(string name)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(name.ToLower())).ToList();
        }

        public void Add(Products product)
        {
            _productDal.Add(product);
        }

        public void Update(Products product)
        {
            _productDal.Update(product);
        }

        public void Delete(Products product)
        {
            try
            {
                _productDal.Delete(product);
                MessageBox.Show("Ürün başarıyla silindi");
            }
            catch (DbUpdateException e)
            {

                MessageBox.Show("Bu ürünü silemezsiniz");
            }
           
        }
    }
}
