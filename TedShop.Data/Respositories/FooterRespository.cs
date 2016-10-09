using TedShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Respositories
{
    public interface IFooterProductRespository : IRespository<Footer>
    {
    }

    public class FooterRespository : RespositoryBase<Footer>, IFooterProductRespository
    {
        public FooterRespository(IDbFactory dbFactory ): base(dbFactory)
        {

        }
    }
}