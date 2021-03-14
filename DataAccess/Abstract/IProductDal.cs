using Core.DataAcces;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product> // İnterface methodları default publicdir. Kendileri değil.
    {
        List<ProductDetailDto> GetProductDetails();
    }
}