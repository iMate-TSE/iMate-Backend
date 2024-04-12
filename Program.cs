using iMate.API.Data;
using iMate.API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));


builder.Services.AddSignalR();
builder.Services.AddScoped<MoodService,  MoodService>();

builder.Services.AddScoped<LoginService, LoginService>();
builder.Services.AddScoped<SettingsService, SettingsService>();
builder.Services.AddScoped<CardService, CardService>();
builder.Services.AddScoped<ProfileService, ProfileService>();

var configuration = builder.Configuration;

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseNpgsql(configuration.GetConnectionString("iMateDatabase"));
});

builder.Services.AddScoped<DatabaseSeeder>();

var app = builder.Build();

app.UseRouting();
app.UseCors("corsapp");

SeedDatabase();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapHub<ChatService>("/ChatHub");

app.Run();

void SeedDatabase()
{
    using (var scope = app.Services.CreateScope())
    {
        var dbSeeder = scope.ServiceProvider.GetRequiredService<DatabaseSeeder>();
        dbSeeder.Initialise();
    }
}
