using System;
using System.Collections.Generic;
using System.Linq;
using TedShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Respositories
{
    public interface IProductCategoryRespository
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }

    public class ProductCategoryRespository : RespositoryBase<ProductCategory>, IProductCategoryRespository
    {
        public ProductCategoryRespository(IDbFactory dbFactory) : base(dbFactory)
        {
            
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
}