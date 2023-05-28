using SuperShop2.Data.Entities;

namespace SuperShop2.Data
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {
            
        }
    }
}
