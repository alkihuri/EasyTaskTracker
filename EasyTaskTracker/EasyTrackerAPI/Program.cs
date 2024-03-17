
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore; 

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
 
builder.Services.AddSingleton<ITaskManager>(provider =>
{
    var optionsBuilder = new DbContextOptionsBuilder<TaskTrackerContext>();
    optionsBuilder.UseSqlite("Data Source=TaskDataBase.db"); 
    var taskContext = new TaskTrackerContext(optionsBuilder.Options);
    taskContext.Database.EnsureCreated(); 
    ITaskRepository taskRepository = new TaskRepository(taskContext);
    ITaskManager taskManager = new TaskManager(taskRepository);

    return taskManager;
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthorization();

app.MapControllers();

app.Run();
