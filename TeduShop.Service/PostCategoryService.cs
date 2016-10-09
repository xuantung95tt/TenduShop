using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TedShop.Data.Infrastructure;
using TedShop.Data.Respositories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IPostCategoryService
    {
        void Add(PostCategory post);

        void Update(PostCategory post);

        void Delete(int id);

        IEnumerable<PostCategory> GetAll();

        IEnumerable<PostCategory> GetAllByParentId(int parentId);

        PostCategory GetById(int id);

        void SaveChanges();
    }
    public class PostCategoryService : IPostCategoryService
    {
        IPostCategoryRespository _postCategoryRespository;
        IUnitOfWork _unitOfWork;
        public PostCategoryService(IPostCategoryRespository postCategoryRespository, IUnitOfWork unitOfWork)
        {
            this._postCategoryRespository = postCategoryRespository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(PostCategory post)
        {
            _postCategoryRespository.Add(post);
        }

        public void Delete(int id)
        {
            _postCategoryRespository.Delete(id);
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
