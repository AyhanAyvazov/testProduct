using ProductWithCategory.Models;
using ProductWithCategory.Repositories.GenericRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWithCategory.Repositories
{
    internal interface ICategoryReposiroty : IGenericRepository<Category>

    {
        Category GetSignleCategoryByIdWithProduct(int categoryId);
    }
}
