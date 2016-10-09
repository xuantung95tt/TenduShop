using TedShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Respositories
{
    public interface ISlideRespository
    {
    }

    public class SlideRespository : RespositoryBase<PostCategory>, ISlideRespository
    {
        public SlideRespository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}