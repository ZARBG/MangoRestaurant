using System.ComponentModel.DataAnnotations;

namespace Mango.Web.Models
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        [Range(0.01, double.MaxValue)]
        public double Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }
    }
}
