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
    }
}
