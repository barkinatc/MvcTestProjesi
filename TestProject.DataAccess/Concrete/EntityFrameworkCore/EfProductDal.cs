using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Core.DataAccess.EntityFrameworkCore;
using TestProject.DataAccess.Abstract;
using TestProject.Entity.ComplexTypes;
using TestProject.Entity.Concrete;

namespace TestProject.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfProductDal : EfEntityRepositoryBase<Product, TestProjectDbContext> ,IProductDal
    {
        public List<ProductCategoryComplexData> GetProductWithCategory()
        {
            using (var _contex = new TestProjectDbContext())
            {
                var result = from p in _contex.Products
                             join c in _contex.Categories on p.CategoryId equals c.Id
                             select new ProductCategoryComplexData
                             {
                                 CategoryName = c.Name,
                                 Height = p.Height,
                                 ProductId = p.Id,
                                 ProductName = p.Name,
                                 Weight = p.Weight,
                                 Width = p.Width

                             };
                return result.ToList();

            }
        }
    }
}
