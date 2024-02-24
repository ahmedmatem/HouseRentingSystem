using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Data.Constants.DataConstants;
using static HouseRentingSystem.Data.Constants.ErrorMessages;

namespace HouseRentingSystem.Data.Models
{
    /// <summary>
    /// House Rent System Category
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Category primary key.
        /// </summary>
        [Key]
        [Comment("Category identifier.")]
        public int Id { get; set; }

        /// <summary>
        /// Category name
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [MaxLength(CategoryNameMaxLength, ErrorMessage = StringMaxLengthErrorMessage)]
        [Comment("Category anme")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Collection of Houses
        /// </summary>
        public IList<House> Houses { get; set; } = new List<House>();
    }
}