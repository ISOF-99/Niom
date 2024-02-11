
using Turin.Context;
using Turin.Entity;
using Turin.Entityes;

namespace ConsoleApp.Repositories
{
    internal class AddressRepository : Reposi<AdressEntity>
    {
        public AddressRepository(DataContext context) : base(context)
        {
        }

        internal new AdressEntity Create(AdressEntity adressEntity)
        {
            throw new NotImplementedException();
        }
    }
}
