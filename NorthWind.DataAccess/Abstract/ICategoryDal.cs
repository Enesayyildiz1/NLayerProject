﻿using NorthWind.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.DataAccess.Abstract
{
   public  interface ICategoryDal:IEntityRepository<Categories>
    {
    }
}
