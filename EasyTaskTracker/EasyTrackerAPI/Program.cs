
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;  
using Microsoft.AspNetCore; 
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;


var builder = WebApplication.CreateBuilder(args);

                          // подключение аутентификации с помощью jwt-токенов


builder.Services.AddAuthorization(); // добавление авторизации    

// Add services to the container.
builder.Services.AddAuthentication("Bearer")
    .AddJwtBearer("Bearer", options =>
    {
        options.Authority = "https://localhost:5001"; // URL вашего Identity Server (если используете)
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidAudience = "your_client_id", // Ваш клиентский идентификатор
            ValidIssuer = "https://localhost:5001", // URL вашего Identity Server (если используете)
            ValidateLifetime = true
        };
    }); 
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


builder.Services.AddDbContext<AccountContext>(options =>
{
    options.UseSqlite("Data Source=AccountDataBase.db"); 
}); 

builder.Services.AddIdentityCore<IdentityUser>()
    .AddEntityFrameworkStores<AccountContext>();

builder.Services.AddScoped<UserManager<IdentityUser>>();
builder.Services.AddScoped<SignInManager<IdentityUser>>();
 
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
 
 



builder.Services.AddHttpContextAccessor();


var app = builder.Build();

// Configure the HTTP request pipeline. 
app.UseAuthentication();
app.UseAuthorization();
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "EasyTaskTracker API v1")); 
app.UseCors();
app.UseHttpsRedirection();
app.UseStaticFiles(); 

app.MapControllers();

app.Run();
