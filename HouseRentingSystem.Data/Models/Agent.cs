using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HouseRentingSystem.Data.Constants.DataConstants;
using static HouseRentingSystem.Data.Constants.ErrorMessages;

namespace HouseRentingSystem.Data.Models
{
    /// <summary>
    /// House renting system Agent
    /// </summary>
    public class Agent
    {
        /// <summary>
        /// Agent unique identifier
        /// </summary>
        [Key]
        [Comment("Agent unique identifier")]
        public int Id { get; set; }

        /// <summary>
        /// Agent phone number
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [Comment("Agent phone number")]
        [MaxLength(AgentPhoneNumberMaxLength, ErrorMessage = StringMaxLengthErrorMessage)]
        public string PhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// Agent user identifier
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [Comment("Agent user identifier")]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey("UserId")]
        public IdentityUser User { get; set; } = null!;

        public IList<House> Houses { get; set; } = new List<House>();
    }
}