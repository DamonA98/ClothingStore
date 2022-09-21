using ClothingStore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString
    ("ClothingStoreDbContextConnection") ?? throw new InvalidOperationException
    ("Connection string 'ClothingStoreDbContextConnection' not found.");

builder.Services.AddDbContext<ClothingStoreDbContext>(options =>
    options.UseSqlServer(connectionString)); ;

builder.Services.AddDefaultIdentity<IdentityUser>()
    .AddEntityFrameworkStores<ClothingStoreDbContext>();

builder.Services.AddControllersWithViews();



builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ISneakersRepository, SneakersRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();

builder.Services.AddScoped<IShoppingCart, ShoppingCart>(sp => ShoppingCart.GetCart(sp));
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();

// Add services to the container.

builder.Services.AddDbContext<ClothingStoreDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:ClothingStoreDbContextConnection"]);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

//app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();

app.UseAuthentication();
app.UseAuthorization();

//app.UseRouting();

//app.MapDefaultControllerRoute();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();
//app.MapFallbackToPage("/app/{*catchall", "/App/Index");
DbInitializer.Seed(app);
app.Run();
