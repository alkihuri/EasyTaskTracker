using EasyTaskTracker.Model;
using Microsoft.EntityFrameworkCore;


public class TaskContext : DbContext
{
    public DbSet<EasyTaskTracker.Model.TrackerTask> Tasks { get; set; }

    public TaskContext(DbContextOptions<TaskContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TrackerTask>().HasKey(tt => tt.Id);

        // Configure many-to-many relationship between TrackerTask and User
        modelBuilder.Entity<TrackerTask>().HasKey(u => u.Id);
        modelBuilder.Entity<TrackerTask>().HasMany(u => u.Asssignies).WithMany(tt => tt.Tasks);

        modelBuilder.Entity<User>().HasKey(u => u.Id);
        modelBuilder.Entity<User>().HasMany(u => u.Tasks).WithMany(tt => tt.Asssignies);

        modelBuilder.Entity<Role>().HasKey(r => r.Name);



    }
}
