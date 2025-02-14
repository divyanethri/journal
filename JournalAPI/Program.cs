using JournalApp.Domain;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("appsettings.json" , optional: false , reloadOnChange: true);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddSingleton<IConfiguration>(builder.Configuration); // Assuming you need a singleton configuration instance

builder.Services.AddDbContext<JournalDbContext>(options =>
{
    options.UseNpgsql("Server=localhost;Database=journaldb; Username=postgres; Password=Nethri@2310.");
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if ( app.Environment.IsDevelopment() )
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
