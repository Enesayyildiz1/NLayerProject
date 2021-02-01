using NorthWind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace NorthWind.DataAccess.Concrete
{
    class ProductDal
    {
        public List<Products> GetAll()
        {
            using (NorthwindEntities1 db=new NorthwindEntities1())
            {
                return db.Products.ToList();
            }
        }
        public Products Get(int id)
        {
            using (NorthwindEntities1 db = new NorthwindEntities1())
            {
                return db.Products.SingleOrDefault(p =>p.ProductID== id);
            }

        }
        public void Add(Products product)
        {
            using (NorthwindEntities1 db = new NorthwindEntities1())
            {
                db.Products.Add (product);
                db.SaveChanges();
            }
        }
        //public void Update(Products product)
        //{
        //    using (NorthwindEntities1 db = new NorthwindEntities1())
        //    {
        //        db.Products.Remove(product);
        //        db.SaveChanges();
        //    }
        //}
        public void Delete(Products product)
        {

        }
    }
}
