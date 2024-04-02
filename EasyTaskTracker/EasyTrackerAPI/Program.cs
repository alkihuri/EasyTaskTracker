
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

builder.Services.AddSingleton<IAccountManager>(provider =>
{
    var optionsBuilder = new DbContextOptionsBuilder<AccountContext>();
    optionsBuilder.UseSqlite("Data Source=AccountDataBase.db"); 
    var accountContext = new AccountContext(optionsBuilder.Options);
    accountContext.Database.EnsureCreated();  
    IAccountManager accountManager = new AccountManager(accountContext);

    return accountManager;
});

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "EasyTaskTracker API", Version = "v1" });
}); 
var app = builder.Build();

// Configure the HTTP request pipeline.
 
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "EasyTaskTracker API v1"));
 

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthorization();

app.MapControllers();

app.Run();
