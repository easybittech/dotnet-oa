var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.UseHttpsRedirection();

app.Run();

public class Company
{
    public string Name { get; set; }
    public List<Department> Departments { get; set; } = [];
}

public class Department
{
    public string Name { get; set; }
    public List<Employee> Employees { get; set; } = [];
}

public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<string> Skills { get; set; } = [];
}