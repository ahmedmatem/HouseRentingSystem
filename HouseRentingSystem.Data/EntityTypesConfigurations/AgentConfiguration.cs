using HouseRentingSystem.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem.Data.EntityTypesConfigurations
{
    public class AgentConfiguration : IEntityTypeConfiguration<Agent>
    {

        public void Configure(EntityTypeBuilder<Agent> builder)
        {
            builder.HasData(SeedAgent());
        }

        private Agent SeedAgent()
        {
            Seeds.Agent = new Agent()
            {
                Id = 1,
                PhoneNumber = "+359888888888",
                UserId = Seeds.AgentUser.Id
            };
            return Seeds.Agent;
        }
    }
}
