
using DataAcessLayer.Concrete;
using DepremBilgiPlatformApp.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Authentication;


var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Context>
    (options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ContextConnection"))
    );
builder.Services.AddIdentity<AppUser, AppRole>(x =>
{
    x.Password.RequireUppercase = false;
    x.Password.RequireNonAlphanumeric = false;
})
               .AddEntityFrameworkStores<Context>().AddDefaultTokenProviders();
builder.Services.AddScoped<DbContext, Context>();
//#region Authorize

//builder.Services.AddMvc(config =>
//    {
//        var policy = new AuthorizationPolicyBuilder()
//    .RequireAuthenticatedUser()
//    .Build();
//        config.Filters.Add(new AuthorizeFilter(policy));
//    });
//builder.Services.AddMvc();
//builder.Services.AddAuthentication(
//    CookieAuthenticationDefaults.AuthenticationScheme)
//    .AddCookie(x =>
//    {
//        x.LoginPath = "/Login/Index/";
//    });

//#endregion

builder.Services.AddControllersWithViews().AddRazorPagesOptions(options => {
    options.Conventions.AddAreaPageRoute("Login", "/Login/Index", "");
});

builder.Services.ConfigureApplicationCookie(o => o.LoginPath = "/Login/Index");

//builder.Services.AddIdentity<AppUser,AppRole>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<Context>().
//    AddDefaultTokenProviders();
//builder.Services.AddScoped<DbContext,Context>();


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

app.UseRouting();

app.UseAuthorization();
app.MapControllerRoute(
           name: "areas",
           pattern: "{area:exists}/{controller=Login}/{action=Index}/{id?}"
         );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");


app.Run();
