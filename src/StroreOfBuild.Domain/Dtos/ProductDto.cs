//Fica na camada de Vizualização
using StoreOfBuild.Domain.Products;

namespace StroreOfBuild.Domain.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }   
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

    }
}