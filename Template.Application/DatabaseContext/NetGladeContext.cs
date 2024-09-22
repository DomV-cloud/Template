using Microsoft.EntityFrameworkCore;
using Template.Domain.Entities;

namespace Template.Application.DatabaseContext
{
    public class TemplateContext : DbContext
    {
        public TemplateContext(DbContextOptions<TemplateContext> options)
            : base(options)
        {

        }

        public DbSet<User> Users => Set<User>();
    }
}
