using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HouseRentingSystem.Data.Constants.DataConstants;
using static HouseRentingSystem.Data.Constants.ErrorMessages;

namespace HouseRentingSystem.Data.Models
{
    /// <summary>
    /// House Renting System House
    /// </summary>
    public class House
    {
        /// <summary>
        /// House primary key.
        /// </summary>
        [Key]
        [Comment("Unique identifier.")]
        public int Id { get; set; }

        /// <summary>
        /// House title
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [MaxLength(HouseTitleMaxLength, ErrorMessage = StringMaxLengthErrorMessage)]
        [Comment("House title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// House address
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [MaxLength(HouseAddressMaxLength, ErrorMessage = StringMaxLengthErrorMessage)]
        [Comment("House address")]
        public string Address { get; set; } = string.Empty;

        /// <summary>
        /// House description
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [MaxLength(HouseDescriptionMaxLength, ErrorMessage = StringMaxLengthErrorMessage)]
        [Comment("House description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// House image url
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [Comment("House image url")]
        public string ImageUrl { get; set; } = string.Empty;

        /// <summary>
        /// House rent price per month - max value 2000
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [Column(TypeName = "decimal(18,2)")]
        [Comment("House rent price per month")]
        public decimal PricePerMonth { get; set; }

        /// <summary>
        /// House Categori identifier
        /// </summary>
        [Required]
        [Comment("House category identifier")]
        public int CategoryId { get; set; }

        /// <summary>
        /// House Agent identifier
        /// </summary>
        [Required]
        [Comment("House Agent identifier")]
        public string AgentId { get; set; } = string.Empty;

        /// <summary>
        /// House Renter identifier
        /// </summary>
        [Required]
        [Comment("House Renter identifier")]
        public int RenterId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; } = null!;

        [ForeignKey("AgentId")]
        public IdentityUser Agent { get; set; } = null!;
    }
}