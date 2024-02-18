using ProductWithCategory.Models;

namespace ProductWithCategory.Repositories
{
    public interface ICategoryReposiroty 

    {
        List<Category> GetAll();

        Category GetById(int categoryId);
    }
}
