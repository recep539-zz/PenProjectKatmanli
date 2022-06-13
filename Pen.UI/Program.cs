using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Pen.Entity.Data;
using Pen.UI.Data;
using Pen.UI.Models;
using Pen.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var connectionString1 = builder.Configuration.GetConnectionString("DefaultConnection1");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDbContext<PenDbCoreContext>(options =>
    options.UseSqlServer(connectionString1));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IUOW,UOW>();
builder.Services.AddScoped<BodyMaterialModel>();
builder.Services.AddScoped<PenStatusModel>();
builder.Services.AddScoped<TipTypeModel>();
builder.Services.AddScoped<PenInformationModel>();
builder.Services.AddScoped<PenInformationDetailModel>();
builder.Services.AddScoped<FillingMechanismModel>();
builder.Services.AddScoped<CoverTypeModel>();
builder.Services.AddScoped<FountainPenModel>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
