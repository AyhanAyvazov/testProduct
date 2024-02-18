using ProductWithCategory.Models;
using ProductWithCategory.Models.Concrete;
using ProductWithCategory.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWithCategory.Services
{
    public class CategoryService : ICategoryReposiroty
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryService(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetById(int categoryId)
        {
            return  _categoryDal.Get(c => c.CategoryId == categoryId);
        }
    }
}
