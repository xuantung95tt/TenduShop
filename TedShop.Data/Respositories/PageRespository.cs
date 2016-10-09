using TedShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Respositories
{
    public interface IPageRespository : IRespository<Page>
    {
    }

    public class PageRespository : RespositoryBase<Page>, IPageRespository
    {
        public PageRespository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}