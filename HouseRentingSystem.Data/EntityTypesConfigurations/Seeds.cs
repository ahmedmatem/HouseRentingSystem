using HouseRentingSystem.Data.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem.Data.EntityTypesConfigurations
{
    public static class Seeds
    {
        public static IdentityUser AgentUser { get; set; }
        public static IdentityUser GuestUser { get; set; }

        public static Agent Agent { get; set; } = null!;

        public static Category CottageCategory { get; set; }
        public static Category SingleCategory { get; set; }
        public static Category DuplexCategory { get; set; }

        public static House FirstHouse { get; set; }
        public static House SecondHouse { get; set; }
        public static House ThirdHouse { get; set; }

        private static IdentityUser GetGuestUser()
        {
            PasswordHasher<IdentityUser> hasher = new PasswordHasher<IdentityUser>();
            var guestUser = new IdentityUser()
            {
                Id = Guid.NewGuid().ToString(),
                NormalizedUserName = "guest@softuni.bg",
                UserName = "guest@softuni.bg",
                NormalizedEmail = "guest@softuni.bg",
                Email = "guest@softuni.bg"
            };
            guestUser.PasswordHash = hasher.HashPassword(guestUser, "guest123");
            return guestUser;
        }

        private static IdentityUser GetAgentUser()
        {
            PasswordHasher<IdentityUser> hasher = new PasswordHasher<IdentityUser>();
            var agentUser = new IdentityUser()
            {
                Id = Guid.NewGuid().ToString(),
                NormalizedUserName = "agent@softuni.bg",
                UserName = "agent@softuni.bg",
                NormalizedEmail = "agent@softuni.bg",
                Email = "agent@softuni.bg"
            };
            agentUser.PasswordHash = hasher.HashPassword(agentUser, "agent123");
            return agentUser;
        }
    }
}
