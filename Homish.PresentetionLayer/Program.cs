using Homish.BusinessLayer.Abstract;
using Homish.BusinessLayer.Concrete;
using Homish.DataAccessLayer.Abstract;
using Homish.DataAccessLayer.Concrete;
using Homish.DataAccessLayer.Settings.Abstract;
using Homish.DataAccessLayer.Settings.Concrete;
using Homish.EntityLayer.Concrete;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IChooseUsService, ChooseUsManager>();
builder.Services.AddScoped<IChooseUsDal, EfChooseUsDal>();
builder.Services.AddScoped<IContactService,ContactManager>();
builder.Services.AddScoped<IContactDal,EfContactDal>();
builder.Services.AddScoped<IHeaderService,HeaderManager>();
builder.Services.AddScoped<IHeaderDal, EfHeaderDal>();
builder.Services.AddScoped<IPlanService,PlanManager>();
builder.Services.AddScoped<IPlanDal,EfPlanDal>();
builder.Services.AddScoped<IPropertyService,PropertyManager>();
builder.Services.AddScoped<IPropertyDal,EfPropertyDal>();
builder.Services.AddScoped<IServiceService, ServiceManager>();
builder.Services.AddScoped<IServiceDal,EfServiceDal>();
builder.Services.AddScoped<IServicePropertyService,ServicePropertyManager>();
builder.Services.AddScoped<IServicePropertyDal,EfServicePropertyDal>();
builder.Services.AddScoped<ITeamService,TeamManager>();
builder.Services.AddScoped<ITeamDal,EfTeamDal>();
builder.Services.AddScoped<ITestimonialService,TestimonialManager>();
builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();
builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettings"));
builder.Services.AddSingleton<IDatabaseSettings>(sp =>
{
    return sp.GetRequiredService<IOptions<DatabaseSettings>>().Value;
});
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

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.Run();
