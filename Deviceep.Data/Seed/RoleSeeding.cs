using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deviceep.Data.Seed
{
  

        public class RoleSeeding : IEntityTypeConfiguration<IdentityRole>
        {
            public void Configure(EntityTypeBuilder<IdentityRole> builder)
            {
            builder.HasData(
                new IdentityRole
                {
                    Name = "UserSlave",
                    NormalizedName = "USERSLAVE"
                },


                new IdentityRole
                {
                    Name = "UserMaster",
                    NormalizedName = "USERMASTER"
                },
                new IdentityRole
                {
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                }
                );
        }
        }
    }

