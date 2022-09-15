using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Core.DataAccess.EntityFrameworkCore;
using TestProject.DataAccess.Abstract;
using TestProject.Entity.Concrete;


namespace TestProject.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category,TestProjectDbContext>, ICategoryDal
    {
    }
}
