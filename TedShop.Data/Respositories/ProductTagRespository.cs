using TedShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Respositories
{
    public interface IProductTagRespository : IRespository<PostCategory>
    {
    }

    public class ProductTagRespository : RespositoryBase<PostCategory>, IProductTagRespository
    {
        public ProductTagRespository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}