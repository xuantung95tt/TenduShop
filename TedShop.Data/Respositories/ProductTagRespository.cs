using TedShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Respositories
{
    public interface IProductTagRepository : IRepository<PostCategory>
    {
    }

    public class ProductTagRepository : RepositoryBase<PostCategory>, IProductTagRepository
    {
        public ProductTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}