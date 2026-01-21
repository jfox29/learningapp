var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Configuration.AddAzureAppConfiguration("Endpoint=https://application-config1000.azconfig.io;Id=wzcx;Secret=4BAn1tqaGe2NdngMIaC88Tinz1baBDGAofTZwSDbdLihqSIWn5ImJQQJ99CAACHYHv6ECXrZAAABAZAC3V4g");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
