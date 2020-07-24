using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace Migrations.Data
{
    public class BlogContextFactory : IDesignTimeDbContextFactory<BlogContext>
    {
        public BlogContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BlogContext>();
            optionsBuilder.UseSqlServer(@"Server=(localdb)\Toturial;Database=BlogDB;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new BlogContext(optionsBuilder.Options);
        }
    }
}
