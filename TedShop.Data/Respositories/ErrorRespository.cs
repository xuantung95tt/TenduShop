using TedShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Respositories
{
    public interface IErrorRespository : IRespository<Error>
    {
    }

    internal class ErrorRespository : RespositoryBase<Error>, IErrorRespository
    {
        public ErrorRespository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}