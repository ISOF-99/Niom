﻿
using System.ComponentModel.DataAnnotations;

namespace Turin.Entityes
{
    internal class AdressEntity
    {
        [Key]
        public int Id { get; set; }
        public string StreetName { get; set; } = null!;
        public string PostalCode { get; set; } = null!;
        public string City { get; set; } = null!;
    }
}
