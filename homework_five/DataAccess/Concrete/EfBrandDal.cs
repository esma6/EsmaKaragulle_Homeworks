﻿using Airliness.Dal.Abstract;
using Airliness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airliness.Dal.Concrete
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, AirlinessContext>, IBrandDal
    {

    }
}
