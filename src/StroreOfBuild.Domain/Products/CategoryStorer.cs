using StoreOfBuild.Domain.Products;
using StroreOfBuild.Domain.Dtos;

namespace StroreOfBuild.Domain.Products
{
    public class CategoryStorer
    {
        private readonly IRepository<Category> _categoryRepository;

        public CategoryStorer(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void Store(CategoryDto dto)
        {
            var category = _categoryRepository.GetbyId(dto.Id);

            if(category == null)
            {
                category = new Category(dto.Name);
                _categoryRepository.Save(category);
            }
            else
            category.Update(dto.Name);
        }
    }
}