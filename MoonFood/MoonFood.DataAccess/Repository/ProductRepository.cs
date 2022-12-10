using MoonFood.DataAccess.Repository.IRepository;
using MoonFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonFood.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext param): base(param)
        {
            _db = param;
        }
        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
            if(objFromDb != null)
            {
                objFromDb.Name = obj.Name;
                objFromDb.Description = obj.Description;
                objFromDb.Price = obj.Price;
                objFromDb.Category = obj.Category;
                objFromDb.CategoryId = obj.CategoryId;
                objFromDb.Weight = obj.Weight;
                if(objFromDb.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }
           //_db.Products.Update(obj);
        }
    }
}
