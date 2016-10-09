using TedShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Respositories
{
    public interface IMenuGroupRespository : IRespository<MenuGroup>
    {
    }

    public class MenuGroupRespository : RespositoryBase<MenuGroup>, IMenuGroupRespository
    {
        public MenuGroupRespository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}