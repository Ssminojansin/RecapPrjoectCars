﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandServise
    {
        List<Brand> GetAll();
        List<Brand> GetById(int brandId);
    }
}