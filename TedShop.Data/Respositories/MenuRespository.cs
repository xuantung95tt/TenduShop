using TedShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Respositories
{
    public interface IMenuRespository
    {
    }

    public class MenuRespository : RespositoryBase<Menu>, IMenuRespository
    {
        public MenuRespository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}