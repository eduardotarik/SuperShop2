using SuperShop2.Data.Entities;
using SuperShop2.Models;

namespace SuperShop2.Helpers
{
    public interface IConverterHelper
    {
        Product ToProduct(ProductViewModel model, string path, bool isNew);

        ProductViewModel ToProductViewModel(Product product);
    }
}
