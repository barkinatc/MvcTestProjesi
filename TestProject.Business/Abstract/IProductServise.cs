using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Entity.ComplexTypes;
using TestProject.Entity.Concrete;

namespace TestProject.Business.Abstract
{
   public interface IProductServise 
    {
        Product Add(Product product);
        Task<Product> AddAsync(Product product);
        Product Update(Product product);
        Task<Product> UpdateAsync(Product product);
        void delete(Product product);
        Product GetById(int id);
        Product GetByName(String name);
        List<Product> GetList();
        List<Product> GetListByCategoryId(int categoryId);
        List<ProductCategoryComplexData> GetProductWithCategory();




    }
}
