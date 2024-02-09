using Microsoft.EntityFrameworkCore;
using NCA_FA2.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add configuration from appsettings.json
builder.Configuration.AddJsonFile("appsettings.json", optional: false);

builder.Services.AddDbContext<FeedbackDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FeedbackInfo")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();