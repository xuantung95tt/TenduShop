﻿using TedShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Respositories
{
    public interface IOrderDetailRespository
    {
    }

    public class OrderDetailRespository : RespositoryBase<OrderDetail>, IOrderDetailRespository
    {
        public OrderDetailRespository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}