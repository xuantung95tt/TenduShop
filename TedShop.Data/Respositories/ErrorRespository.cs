using TedShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Respositories
{
    public interface IErrorRepository : IRepository<Error>
    {
    }

    internal class ErrorRepository : RepositoryBase<Error>, IErrorRepository
    {
        public ErrorRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}