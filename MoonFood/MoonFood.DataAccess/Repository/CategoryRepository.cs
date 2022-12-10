using MoonFood.DataAccess.Repository.IRepository;
using MoonFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonFood.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext param): base(param)
        {
            _db = param;
        }
        public void Update(Category obj)
        {
           _db.Categories.Update(obj);
        }
    }
}
