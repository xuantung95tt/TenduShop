using TedShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Respositories
{
    public interface IPostCategoryRespository
    {
    }

    public class PostCategoryRespository : RespositoryBase<PostCategory>, IPostCategoryRespository
    {
        public PostCategoryRespository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}