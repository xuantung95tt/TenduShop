using TedShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Respositories
{
    public interface ISystemConfigRespository
    {
    }

    public class SystemConfigRespository : RespositoryBase<PostCategory>, ISystemConfigRespository
    {
        public SystemConfigRespository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}