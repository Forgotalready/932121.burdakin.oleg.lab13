using Lab13.Data.Repository;
using Lab13.Generator;
using Lab13.Services;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<QuestionGenerator>();
builder.Services.AddSingleton<CalculationService>();
builder.Services.AddSingleton<QuestionRepository>();

WebApplication app = builder.Build();

if (!app.Environment.IsDevelopment())
{
  app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
      name: "default",
      pattern: "{controller=Home}/{action=Index}/{id?}"
    );

app.Run();