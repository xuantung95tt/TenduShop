using TedShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Respositories
{
    public interface ITagRespository
    {
    }

    public class TagRespository : RespositoryBase<PostCategory>, ITagRespository
    {
        public TagRespository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}