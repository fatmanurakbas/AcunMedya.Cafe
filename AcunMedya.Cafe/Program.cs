using AcunMedya.Cafe.Context;
using AcunMedya.Cafe.Services;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // 1️⃣ MVC ve FluentValidation servisleri
        builder.Services.AddControllersWithViews();

        builder.Services.AddFluentValidationAutoValidation() // ModelState için FluentValidation
                        .AddFluentValidationClientsideAdapters() // Tarayıcı tarafı hataları
                        .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly()); // Validator'ları tanı

        // 2️⃣ DbContext
        builder.Services.AddDbContext<CafeContext>();

        // 3️⃣ Bildirim servisi
        builder.Services.AddScoped<NotificationService>();

        // 4️⃣ Cookie Authentication (login için)
        builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options =>
            {
                options.LoginPath = "/Login/Index";     // Giriş yapılmamışsa yönlendirilecek adres
                options.LogoutPath = "/Login/Logout";   // Çıkış adresi
                options.AccessDeniedPath = "/Login/AccessDenied"; // Yetki yoksa yönlendirme (opsiyonel)
            });

        var app = builder.Build();

        // 5️⃣ 404 error page middleware
        app.UseStatusCodePagesWithReExecute("/ErrorPage/Page404");

        // 6️⃣ Ortam kontrolü
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        // 7️⃣ HTTPS ve statik dosya yönetimi
        app.UseHttpsRedirection();
        app.UseStaticFiles();

        // 8️⃣ Authentication ve Authorization middleware
        app.UseRouting();
        app.UseAuthentication();
        app.UseAuthorization();

        // 9️⃣ Ana route
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Default}/{action=Index}/{id?}");

        // 🔟 Area route
        app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");



        // 1️⃣1️⃣ Uygulamayı başlat
        app.Run();
    }
}
