using TedShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Respositories
{
    public interface ISystemConfigRespository : IRespository<SystemConfig>
    {
    }

    public class SystemConfigRespository : RespositoryBase<SystemConfig>, ISystemConfigRespository
    {
        public SystemConfigRespository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}