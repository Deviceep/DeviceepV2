using Deviceep.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deviceep.Data.Seed
{
    class UserDepartmentSeed : IEntityTypeConfiguration<UserDepartment>
    {
         
        
        public void Configure(EntityTypeBuilder<UserDepartment> builder)
        {
            
        }
    }
}
