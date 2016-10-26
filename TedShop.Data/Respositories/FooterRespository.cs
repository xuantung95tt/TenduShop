using TedShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Respositories
{
    public interface IFooterProductRepository : IRepository<Footer>
    {
    }

    public class FooterRepository : RepositoryBase<Footer>, IFooterProductRepository
    {
        public FooterRepository(IDbFactory dbFactory ): base(dbFactory)
        {

        }
    }
}