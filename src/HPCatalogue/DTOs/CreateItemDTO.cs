using System;
using System.ComponentModel.DataAnnotations;

namespace HPCatalogue.DTOs
{
    public record CreateItemDTO
    {
        [Required]
        public string Name { get; init; }

        [Required]
        [Range(1, 500)]
        public decimal Price { get; init; }

    }
}