using Turin.Context;
using Turin.Entity;

namespace ConsoleApp.Repositories
{
    internal class ProductsRepository : Reposi<ProductsEntity>
    {
        private readonly DataContext _context;

        public ProductsRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        internal ProductsEntity Add (ProductsEntity productEntity)
        {
            throw new NotImplementedException();
        }
    }
}
