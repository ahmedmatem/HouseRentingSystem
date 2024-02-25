using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem.Data.EntityTypesConfigurations
{
    public class IdentityConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            builder.HasData(SeedUsers());
        }

        private IdentityUser[] SeedUsers()
        {
            return new[] { GetGuestUser(), GetAgentUser() };
        }

        private static IdentityUser GetGuestUser()
        {
            PasswordHasher<IdentityUser> hasher = new PasswordHasher<IdentityUser>();
            Seeds.GuestUser = new IdentityUser()
            {
                Id = Guid.NewGuid().ToString(),
                NormalizedUserName = "guest@softuni.bg",
                UserName = "guest@softuni.bg",
                NormalizedEmail = "guest@softuni.bg",
                Email = "guest@softuni.bg"
            };
            Seeds.GuestUser.PasswordHash = hasher.HashPassword(Seeds.GuestUser, "guest123");
            return Seeds.GuestUser;
        }

        private static IdentityUser GetAgentUser()
        {
            PasswordHasher<IdentityUser> hasher = new PasswordHasher<IdentityUser>();
            Seeds.AgentUser = new IdentityUser()
            {
                Id = Guid.NewGuid().ToString(),
                NormalizedUserName = "agent@softuni.bg",
                UserName = "agent@softuni.bg",
                NormalizedEmail = "agent@softuni.bg",
                Email = "agent@softuni.bg"
            };
            Seeds.AgentUser.PasswordHash = hasher.HashPassword(Seeds.AgentUser, "agent123");
            return Seeds.AgentUser;
        }
    }
}
