﻿using TedShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Respositories
{
    public interface IOrderRepository : IRepository<Order>
    {
    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}