using AspNetCoreValidationStudents.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// �������� ������ ����������� �� ����� ������������
string? connection = builder.Configuration.GetConnectionString("DefaultConnection");

// ��������� �������� ApplicationContext � �������� ������� � ����������
builder.Services.AddDbContext<StudentContext>(options => options.UseSqlServer(connection));

// ��������� ������� MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles(); // ������������ ������� � ������ � ����� wwwroot

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Books}/{action=Create}/{id?}");

app.Run();
