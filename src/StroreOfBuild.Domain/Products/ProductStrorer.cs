//Validar e criar produto
using StoreOfBuild.Domain;
using StoreOfBuild.Domain.Products;
using StroreOfBuild.Domain.Dtos;

namespace StroreOfBuild.Domain.Products
{
    public class ProductStrorer
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IRepository<Category> _categoryRepository;

        public ProductStrorer(IRepository<Product> productRepository, IRepository<Category> categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        public void Store(ProductDto dto)
        {
            var category = _categoryRepository.GetbyId(dto.Id);
            DomainException.When(category == null, "Category invalid");

            var product = _productRepository.GetbyId(dto.Id);
            if(product == null)
            {
                product = new Product(dto.Name, category, dto.Price, dto.StockQuantity);
                _productRepository.Save(product);
            }
            else
                product.Update(dto.Name, category, dto.Price, dto.StockQuantity);
        }
    }
}