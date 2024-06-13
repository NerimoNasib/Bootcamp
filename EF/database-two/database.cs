using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

public class Database : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<School> Schools { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source =  ./database.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<School>(cat =>
        {
            cat.HasKey(c => c.SchoolID);
            cat.Property(c => c.Description).HasColumnType("TEXT");
            cat.HasMany(c => c.Students).WithOne(p => p.School);
        });

        modelBuilder.Entity<Student>(cat =>
        {
            cat.HasKey(c => c.StudentID);
            cat.Property(c => c.Description).HasColumnType("TEXT");
        });
    }
}