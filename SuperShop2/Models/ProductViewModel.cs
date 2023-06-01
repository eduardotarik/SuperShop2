using Microsoft.AspNetCore.Http;
using SuperShop2.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace SuperShop2.Models
{
    public class ProductViewModel : Product
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }
    }
}
