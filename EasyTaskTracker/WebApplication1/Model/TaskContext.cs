using EasyTaskTracker.Model;
using Microsoft.EntityFrameworkCore;


public class TaskContext : DbContext
{
    public DbSet<EasyTaskTracker.Model.Task> Tasks { get; set; }

    public TaskContext(DbContextOptions<TaskContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EasyTaskTracker.Model.Task>().HasKey("Id");
    }
}
