﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using place2024.Data;
using place2024.Models;

var builder = WebApplication.CreateBuilder(args);





//------
//Context de l'app.
builder.Services.AddDbContext<place2024Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("place2024Context") ?? throw new InvalidOperationException("Connection string 'place2024Context' not found.")));


//------
//Services Identity.
builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<place2024Context>();

// Add services to the container.
builder.Services.AddControllersWithViews();
//-----




var app = builder.Build();



using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}






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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
