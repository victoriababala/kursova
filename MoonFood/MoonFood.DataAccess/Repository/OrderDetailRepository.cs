using MoonFood.DataAccess.Repository.IRepository;
using MoonFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonFood.DataAccess.Repository
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        private ApplicationDbContext _db;
        public OrderDetailRepository(ApplicationDbContext param): base(param)
        {
            _db = param;
        }
        public void Update(OrderDetail obj)
        {
           _db.OrderDetail.Update(obj);
        }
    }
}
