var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();

builder.Services.AddTransient<EmployeeService, IEmployeeService>();

builder.Services.AddScoped<EmployeeRepository, IEmployeeRepository>();
builder.Services.AddDbContext(option=>
{
    option.UseMysql(builder.Configuration.ConnectionString("MyConnection"));
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.MapControllers();


app.Run();

