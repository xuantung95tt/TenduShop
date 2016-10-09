using System.Collections.Generic;
using TedShop.Data.Infrastructure;
using TedShop.Data.Respositories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IPostCategoryService
    {
        PostCategory Add(PostCategory post);

        void Update(PostCategory post);

        PostCategory Delete(int id);

        IEnumerable<PostCategory> GetAll();

        IEnumerable<PostCategory> GetAllByParentId(int parentId);

        PostCategory GetById(int id);

        void SaveChanges();
    }

    public class PostCategoryService : IPostCategoryService
    {
        private IPostCategoryRespository _postCategoryRespository;
        private IUnitOfWork _unitOfWork;

        public PostCategoryService(IPostCategoryRespository postCategoryRespository, IUnitOfWork unitOfWork)
        {
            this._postCategoryRespository = postCategoryRespository;
            this._unitOfWork = unitOfWork;
        }

        public PostCategory Add(PostCategory post)
        {
            return _postCategoryRespository.Add(post);
        }

        public PostCategory Delete(int id)
        {
            return _postCategoryRespository.Delete(id);
        }

        public IEnumerable<PostCategory> GetAll()
        {
            return _postCategoryRespository.GetAll();
        }

        public IEnumerable<PostCategory> GetAllByParentId(int parentId)
        {
            return _postCategoryRespository.GetMulti(x => x.ParentID == parentId && x.Status);
        }

        public PostCategory GetById(int id)
        {
            return _postCategoryRespository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(PostCategory post)
        {
            _postCategoryRespository.Update(post);
        }
    }
}