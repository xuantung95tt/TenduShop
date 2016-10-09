using TedShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Respositories
{
    public interface ITagRespository : IRespository<Tag>
    {
    }

    public class TagRespository : RespositoryBase<Tag>, ITagRespository
    {
        public TagRespository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}