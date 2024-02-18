using ProductWithCategory.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWithCategory.Models.Concrete
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}
