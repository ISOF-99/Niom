using Turin.Context;
using Turin.Entity;

namespace ConsoleApp.Repositories
{
    internal class CategoryRepository : Reposi<CategoryEntity>
    {
        public CategoryRepository(DataContext context) : base(context)
        {
        }
    }
}
