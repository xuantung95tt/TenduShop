using TedShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Respositories
{
    public interface IProductRespository
    {
    }

    public class ProductRespository : RespositoryBase<Product>, IProductRespository
    {
        public ProductRespository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}