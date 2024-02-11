using ConsoleApp.Repositories;
using Turin.Entityes;

namespace Turin.Services
{
    internal class AddressService
    {
        private readonly AddressRepository _addressRepository;

        public AddressService(AddressRepository addressRepository)
        {
            _addressRepository = addressRepository ?? throw new ArgumentNullException(nameof(addressRepository));
        }

        public AdressEntity CreateAdress(string streetName, string postalCode, string city)
        {
            var addressEntity = _addressRepository.Get(x => x.StreetName == streetName && x.PostalCode == postalCode && x.City == city);
            addressEntity ??= _addressRepository.Create(new AdressEntity { StreetName = streetName, PostalCode = postalCode, City = city });
            return addressEntity;
        }

        public AdressEntity GetAdress(string streetName, string postalCode, string city)
        {
            return _addressRepository.Get(x => x.StreetName == streetName && x.PostalCode == postalCode && x.City == city);
        }

        public AdressEntity GetAdressById(int id)
        {
            return _addressRepository.Get(x => x.Id == id);
        }

        public IEnumerable<AdressEntity> GetAdresses()
        {
            return _addressRepository.GetAll();
        }

        public AdressEntity UpdateAdress(AdressEntity addressEntity)
        {
            return _addressRepository.Update(x => x.Id == addressEntity.Id, addressEntity);
        }

        public void DeleteAdress(int id)
        {
            _addressRepository.Delete(x => x.Id == id);
        }
    }
}
