using hc_project_children.Types;
using Microsoft.EntityFrameworkCore;

namespace hc_project_children;

public sealed class DatabaseContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Parent> Parents { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Parent>().HasData(
            new Parent()
            {
                Id = 1,
                Name = "parent1"
            });

        modelBuilder.Entity<Parent>().HasData(
            new Parent()
            {
                Id = 2,
                Name = "parent2"
            });

        modelBuilder.Entity<Parent>().HasData(
            new Parent()
            {
                Id = 3,
                Name = "parent3"
            });

        modelBuilder.Entity<Child>().HasData(new Child() { Id = 1, ParentId = 1, Name = "child1" });
        modelBuilder.Entity<Child>().HasData(new Child() { Id = 2, ParentId = 1, Name = "child2" });
        modelBuilder.Entity<Child>().HasData(new Child() { Id = 3, ParentId = 2, Name = "child3" });
        modelBuilder.Entity<Child>().HasData(new Child() { Id = 4, ParentId = 2, Name = "child4" });
        modelBuilder.Entity<Child>().HasData(new Child() { Id = 5, ParentId = 3, Name = "child5" });
        modelBuilder.Entity<Child>().HasData(new Child() { Id = 6, ParentId = 3, Name = "child6" });
    }
}
