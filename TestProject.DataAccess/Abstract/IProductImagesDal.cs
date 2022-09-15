using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Core.DataAccess;
using TestProject.Entity.Concrete;

namespace TestProject.DataAccess.Abstract
{
    public interface IProductImageDal : IEntityRepository<ProductImage>
    {
    }
}

