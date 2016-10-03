namespace TedShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private TenduShopDbContext dbContext;

        public TenduShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TenduShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}