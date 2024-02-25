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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(SeedCategories());
        }

        private Category[] SeedCategories()
        {
            Seeds.CottageCategory = new Category()
            {
                Id = 1,
                Name = "Cottage"
            };

            Seeds.SingleCategory = new Category()
            {
                Id = 2,
                Name = "Single"
            };

            Seeds.DuplexCategory = new Category()
            {
                Id = 3,
                Name = "Duplex"
            };

            return new Category[] 
            { 
                Seeds.CottageCategory,
                Seeds.SingleCategory,
                Seeds.DuplexCategory
            };
        }
    }
}
