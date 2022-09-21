using ClothingStore.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IShoppingCart, ShoppingCart>(sp => ShoppingCart.GetCart(sp));

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ISneakersRepository, SneakersRepository>();


builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ClothingStoreDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:ClothingStoreDbContextConnection"]);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();

app.UseRouting();

app.UseAuthorization();

//app.MapDefaultControllerRoute();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
DbInitializer.Seed(app);
app.Run();
