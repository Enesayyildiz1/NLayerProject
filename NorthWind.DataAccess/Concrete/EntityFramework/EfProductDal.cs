﻿using NorthWind.DataAccess.Abstract;
using NorthWind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;



namespace NorthWind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal :EfEntityRepositoryBase<Products,NorthwindEntities1>,IProductDal
    {
        
    }
}
