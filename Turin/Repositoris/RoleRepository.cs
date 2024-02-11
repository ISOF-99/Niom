using Turin.Context;
using Turin.Entity;

namespace ConsoleApp.Repositories
{
    internal class RoleRepository : Reposi<RoleEntity>
    {
        public RoleRepository(DataContext context) : base(context)
        {
        }
    }
}