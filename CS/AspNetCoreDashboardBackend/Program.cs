using AspNetCoreDashboardBackend.Code;
using DevExpress.AspNetCore;
using DevExpress.DashboardAspNetCore;
using DevExpress.DashboardWeb;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

IFileProvider? fileProvider = builder.Environment.ContentRootFileProvider;
IConfiguration? configuration = builder.Configuration;

// Configures services to use the Web Dashboard Control.
builder.Services.AddCors(options => {
    options.AddPolicy("CorsPolicy", builder => {
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.WithHeaders("Content-Type");
    });
});
builder.Services.AddDevExpressControls();
builder.Services.AddControllers();

builder.Services.AddScoped<DashboardConfigurator>((IServiceProvider serviceProvider) => {
    return DashboardUtils.CreateDashboardConfigurator(configuration, fileProvider);
});

var app = builder.Build();

app.UseDevExpressControls();
app.UseRouting();
app.UseCors("CorsPolicy");

// Maps the dashboard route.
app.MapDashboardRoute("api/dashboard", "DefaultDashboard");
// Requires CORS policies.
app.MapControllers().RequireCors("CorsPolicy");

app.Run();
