using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
services.AddControllersWithViews();
services.AddAuthentication("Cookie")
.AddCookie("Cookie", options =>
{
    options.LoginPath = "/Account/Login";
    options.Cookie.Name = "CookieAuth";
});
var app = builder.Build();

app.UseStaticFiles();

app.UseAuthentication();  // xác thực 

app.UseAuthorization(); 

app.MapControllerRoute(
    name: "Default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
