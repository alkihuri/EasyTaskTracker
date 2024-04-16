
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;  
using Microsoft.AspNetCore; 
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


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
 
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "EasyTaskTracker API", Version = "v1" });
}); 

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder =>
        {
             builder.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});
 
builder.Services.AddDbContext<AccountContext>(options =>
{
    options.UseSqlite("Data Source=Accounts.db"); 
});  

builder.Services.AddIdentity<User, IdentityRole>(options =>
{
    
}) 
.AddEntityFrameworkStores<AccountContext>() ;
 

var app = builder.Build();

// Configure the HTTP request pipeline.
 
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "EasyTaskTracker API v1"));
 

app.UseAuthorization();
app.UseAuthentication();
app.UseCors();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthorization();

app.MapControllers();

app.Run();
