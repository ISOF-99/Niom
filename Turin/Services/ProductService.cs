
using ConsoleApp.Repositories;
using Turin.Entity;


namespace Turin.Services
{
    internal class ProductService
    {
        private readonly ProductsRepository _productRepository;
        private readonly CategoryService _categoryService;

        public ProductService(ProductsRepository productRepository, CategoryService categoryService)
        {
            _productRepository = productRepository;
            _categoryService = categoryService;
        }


        public ProductsEntity CreateProduct(string title, decimal price, string categoryName)
        {

            var categoryEntity = _categoryService.CreateCategory(categoryName);

            var productEntity = new ProductsEntity
            {
                Title = title,
                Price = price,
                CategoryId = categoryEntity.Id,
            };

            productEntity = _productRepository.Create(productEntity);
            return productEntity;
        }



        public ProductsEntity GetProductById(int id)
        {
            var productEntity = _productRepository.Get(x => x.Id == id);
            return productEntity;
        }

        public IEnumerable<ProductsEntity> GetProducts()
        {
            var products = _productRepository.GetAll();
            return products;
        }

        public ProductsEntity UpdateProduct(ProductsEntity productEntity)
        {
            var updatedProductEntity = _productRepository.Update(x => x.Id == productEntity.Id, productEntity);
            return updatedProductEntity;
        }


        public void DeleteProduct(int id)
        {
            _productRepository.Delete(x => x.Id == id);
        }
    }
}
