using NorthWind.Concrete.EntityFramework;
using NorthWind.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.DataAccess.Concrete.EntityFramework
{
    public  class EfCategoryDal:EfEntityRepositoryBase<Categories,NorthwindEntities1>,ICategoryDal
    {
    }
}
