﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using TedShop.Data.Infrastructure;
using TedShop.Data.Respositories;
using TeduShop.Model.Models;
using TeduShop.Service;
using System.Linq;

namespace TeduShop.UnitTest.ServiceTest
{
    [TestClass]
    public class PostCategoryServiceTest
    {
        private Mock<IPostCategoryRespository> _mockRespository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private IPostCategoryService _categoryService;
        private List<PostCategory> _listCategory;

        [TestInitialize]
        public void Initialize()
        {
            _mockRespository = new Mock<IPostCategoryRespository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _categoryService = new PostCategoryService(_mockRespository.Object, _mockUnitOfWork.Object);
            _listCategory = new List<PostCategory>()
            {
                new PostCategory() {ID=1, Name="DM1", Status=true },
                new PostCategory() {ID=2, Name="DM2", Status=true },
                new PostCategory() {ID=2, Name="DM3", Status=true }
            };
        }

        [TestMethod]
        public void PostCategory_Service_GetAll()
        {
            //setup method
            _mockRespository.Setup(m => m.GetAll(null)).Returns(_listCategory);
            //call action
            var result = _categoryService.GetAll() as List<PostCategory>;
            //compare
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count());
        }

        [TestMethod]
        public void PostCategory_Service_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test";
            category.Alias = "Test";
            category.Status = true;

            _mockRespository.Setup(m => m.Add(category)).Returns((PostCategory p) =>
              {
                  p.ID = 1;
                  return p;
              });
            var result = _categoryService.Add(category);
            Assert.IsNotNull(result);
            Assert.AreEqual(result.ID, 1);
        }
    }
}