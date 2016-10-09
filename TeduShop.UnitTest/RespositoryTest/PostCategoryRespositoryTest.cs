using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using TedShop.Data.Infrastructure;
using TedShop.Data.Respositories;
using TeduShop.Model.Models;

namespace TeduShop.UnitTest.RespositoryTest
{
    [TestClass]
    public class PostCategoryRespositoryTest
    {
        private IDbFactory dbFactory;
        private IPostCategoryRespository objRespository;
        private IUnitOfWork unitOfWork;

        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objRespository = new PostCategoryRespository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }

        [TestMethod]
        public void PostCategory_Respository_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test category";
            category.Alias = "Test-category";
            category.Status = true;

            var result = objRespository.Add(category);
            unitOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(6, result.ID);
        }
        [TestMethod]
        public void PostCategory_Respository_GetAll()
        {
            var list = objRespository.GetAll().ToList();
            Assert.AreEqual(3, list.Count);
        }
    }
}