using SuperShop2.Data.Entities;
using System.Linq;

namespace SuperShop2.Data
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public IQueryable GetAllWithUsers();
    }
}
