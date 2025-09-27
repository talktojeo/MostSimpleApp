var builder = WebApplication.CreateBuilder(args);

// Get connection string
var connStr = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connStr));

var app = builder.Build();

// Middleware
app.UseStaticFiles();
app.UseRouting();
app.MapDefaultControllerRoute();

app.Run();
