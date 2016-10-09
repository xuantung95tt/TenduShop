﻿using TedShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Respositories
{
    public interface IPostRespository
    {
    }

    public class PostRespository : RespositoryBase<Post>, IPostRespository
    {
        public PostRespository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}