using TedShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Respositories
{
    public interface IFooterProductRespository
    {
    }

    public class FooterRespository : RespositoryBase<Footer>, IFooterProductRespository
    {
        public FooterRespository(IDbFactory dbFactory ): base(dbFactory)
        {

        }
    }
}