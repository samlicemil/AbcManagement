using AbcManagement.Core.Entities.Concrete;
using AbcManagement.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcManagement.DataAccess.Concrete.EntityFramework
{
    public class AbcManagementContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=CEMILSAMLI;Database=abcmanagement;Trusted_Connection=true");
        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectCategory> ProjectCategories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaims> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

    }
}
