using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Entity.Concrete;

namespace TestProject.Business.Abstract
{
    public interface IProductImageService
    {
        ProductImage Add(ProductImage productImage);
        ProductImage Update(ProductImage productImage);
        void Delete(ProductImage productImage);
        ProductImage GetById(int id);
        List<ProductImage> GetList();
        List<ProductImage> GetListByProductId(int productId);
    }
}
