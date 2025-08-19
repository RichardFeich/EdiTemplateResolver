using CPDI.EdiFabric.Utilities.WebValidator.Components;
using CPDI.EdiFabric.Utilities.WebValidator.Service;

var builder = WebApplication.CreateBuilder(args);

EdiFabric.SerialKey.Set("ca157c4e10e14ef1990daa75ae3be4f8");

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddScoped<IEdiValidationService, EdiValidationService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
