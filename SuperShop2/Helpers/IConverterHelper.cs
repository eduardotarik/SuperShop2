using SuperShop2.Data.Entities;
using SuperShop2.Models;
using System;

namespace SuperShop2.Helpers
{
    public interface IConverterHelper
    {
        Product ToProduct(ProductViewModel model, Guid imageId, bool isNew);

        ProductViewModel ToProductViewModel(Product product);
    }
}
