using TedShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Respositories
{
    public interface ISupportOnlineRespository
    {
    }

    public class SupportOnlineRespository : RespositoryBase<PostCategory>, ISupportOnlineRespository
    {
        public SupportOnlineRespository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}