
using System.ComponentModel.DataAnnotations;
using Turin.Entityes;
namespace Turin.Entity
{
    internal class CustomerEntity
    {

        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;

        public int RoleId { get; set; }
        public RoleEntity Role { get; set; } = null!;


        public int AddressId { get; set; }
        public AdressEntity Address { get; set; } = null!;

    }
}
