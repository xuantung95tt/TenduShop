using TedShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Respositories
{
    public interface IPostTagRespository : IRespository<PostCategory>
    {
    }

    public class PostTagRespository : RespositoryBase<PostCategory>, IPostTagRespository
    {
        public PostTagRespository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}