﻿using TedShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Respositories
{
    public interface IMenuGroupRespository
    {
    }

    public class MenuGroupRespository : RespositoryBase<MenuGroup>, IMenuGroupRespository
    {
        public MenuGroupRespository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}