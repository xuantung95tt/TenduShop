using TedShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Respositories
{
    public interface IVisitorStatisticRespository
    {
    }

    public class VisitorStatisticRespository : RespositoryBase<PostCategory>, IVisitorStatisticRespository
    {
        public VisitorStatisticRespository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}