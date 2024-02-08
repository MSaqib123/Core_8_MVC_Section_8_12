using Microsoft.AspNetCore.HttpLogging;
using ServiceDL;
using ServiceInterfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//=============================
//---- Register services -----
//=============================
#region Services
//___ 1st Way ____
//builder.Services.Add(new ServiceDescriptor(
//    typeof(ICitiesService),
//    typeof(CitiesService),
//    ServiceLifetime.Scoped
// ));

//___ 2nd Way ____
builder.Services.AddScoped<ICitiesService,CitiesService>();

//___ 3rd Way if we have paraterize service____
//builder.Services.AddScoped<typeof(ICitiesService<>),typeof(CitiesService<>)>();

#endregion

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
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
