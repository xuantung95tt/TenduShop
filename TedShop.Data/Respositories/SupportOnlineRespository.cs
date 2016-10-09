using TedShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Respositories
{
    public interface ISupportOnlineRespository : IRespository<SupportOnline>
    {
    }

    public class SupportOnlineRespository : RespositoryBase<SupportOnline>, ISupportOnlineRespository
    {
        public SupportOnlineRespository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}