
using System.ComponentModel.DataAnnotations;

namespace Turin.Entity
{
    internal class CategoryEntity
    {

        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; } = null!;


    }
}
