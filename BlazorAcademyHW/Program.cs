using Microsoft.EntityFrameworkCore;
using BlazorAcademyHW.Components;
using BlazorAcademyHW.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<BlazorAcademyHWContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BlazorAcademyHWContext") ?? throw new InvalidOperationException("Connection string 'BlazorAcademyHWContext' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();;

// Добавление сервиса DbContext
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<Pd321Context>(options =>
    options.UseSqlServer(connectionString));

// Существующие сервисы
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

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
