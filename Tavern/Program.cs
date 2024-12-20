using Tavern.Components;
using Tavern.Data;
using Blazored.LocalStorage;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddScoped<Database>();
builder.Services.AddBlazoredLocalStorage();
builder.Configuration.AddJsonFile("secrets.json",
        optional: true,
        reloadOnChange: true);
var app = builder.Build();
Environment.SetEnvironmentVariable("userLogin", "false");
Environment.SetEnvironmentVariable("usersName", null);
Environment.SetEnvironmentVariable("userID", null);
Environment.SetEnvironmentVariable("ConnectionStr", builder.Configuration.GetSection("MySQL:ConnectionString").Value);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
