using TedShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Respositories
{
    public interface IPostTagRepository : IRepository<PostCategory>
    {
    }

    public class PostTagRepository : RepositoryBase<PostCategory>, IPostTagRepository
    {
        public PostTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}