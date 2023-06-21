using Microsoft.AspNetCore.Mvc.Rendering;
using SuperShop2.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SuperShop2.Data
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public IQueryable GetAllWithUsers();

        IEnumerable<SelectListItem> GetComboProducts();
    }
}
