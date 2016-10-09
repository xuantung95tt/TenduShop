using TedShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Respositories
{
    public interface IVisitorStatisticRespository : IRespository<VisitorStatistic>
    {
    }

    public class VisitorStatisticRespository : RespositoryBase<VisitorStatistic>, IVisitorStatisticRespository
    {
        public VisitorStatisticRespository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}