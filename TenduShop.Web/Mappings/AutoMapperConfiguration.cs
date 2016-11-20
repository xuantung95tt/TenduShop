﻿using AutoMapper;
using TeduShop.Model.Models;
using TeduShop.Web.Models;

namespace TeduShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Post, PostViewModel>().MaxDepth(2);
                cfg.CreateMap<PostCategory, PostCategoryViewModel>().MaxDepth(2);
                cfg.CreateMap<Tag, TagViewModel>().MaxDepth(2);

                cfg.CreateMap<Product, ProductViewModel>().MaxDepth(2);
                cfg.CreateMap<ProductTag, ProductTagViewModel>().MaxDepth(2);
                cfg.CreateMap<ProductCategory, ProductCategoryViewModel>().MaxDepth(2);

                cfg.CreateMap<Footer, FooterViewModel>().MaxDepth(2);
                cfg.CreateMap<Slide, SlideViewModel>().MaxDepth(2);
            });
        }
    }
}