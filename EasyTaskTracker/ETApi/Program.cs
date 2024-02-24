using Microsoft.EntityFrameworkCore; 


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register your DbContext and services with a scoped lifetime
builder.Services.AddScoped<ITaskManager>(provider =>
{
    var optionsBuilder = new DbContextOptionsBuilder<TaskContext>();
    optionsBuilder.UseSqlite("Data Source=TaskDataBase.db");

    var taskContext = new TaskContext(optionsBuilder.Options);
    taskContext.Database.EnsureCreated();
    // Assuming TaskRepository and TaskManager require a TaskContext in their constructors
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
