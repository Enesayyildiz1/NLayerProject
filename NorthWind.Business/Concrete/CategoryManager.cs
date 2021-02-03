using NorthWind.Business.Abstract;
using NorthWind.DataAccess.Abstract;
using NorthWind.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        EfCategoryDal EfCategoryDal = new EfCategoryDal();
        public List<Categories> GetAll()
        {
            return _categoryDal.GetAll();
        }
    }
}
