
using System.ComponentModel.DataAnnotations;

namespace Turin.Entity
{
    internal class RoleEntity
    {
        [Key]
        public int Id { get; set; }
        public string RoleName { get; set; } = null!;

    }
}
