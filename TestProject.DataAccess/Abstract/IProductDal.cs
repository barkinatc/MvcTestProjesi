﻿using System.Collections.Generic;
using TestProject.Core.DataAccess;
using TestProject.Entity.ComplexTypes;
using TestProject.Entity.Concrete;

namespace TestProject.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductCategoryComplexData> GetProductWithCategory();
    }
}
