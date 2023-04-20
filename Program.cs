using Microsoft.OpenApi.Models;
using SwaggerDITest.Algorythms.Interface;
using SwaggerDITest.Algorythms;
using Microsoft.Extensions.Options;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IBubbleSort, BubbleSort>();
builder.Services.AddScoped<IInsertionSort, InsertionSort>();
builder.Services.AddScoped<IMergeSort, MergeSort>();
builder.Services.AddScoped<IQuickSort, QuickSort>();
builder.Services.AddScoped<ISelectionSort, SelectionSort>();
builder.Services.AddScoped<ITreeSort, TreeSort>();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "AddingStuffAndCheckingI", Version = "v1" });
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});


builder.Services.AddControllers();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

if (app.Environment.IsDevelopment())
{
    // middleware który doda Swagger JSON
    app.UseSwagger();
    // middleware do swagger-ui (HTML, JS, CSS, etc.),
    // tutaj okreœlasz endpoint dla Swagger JSON
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "AddingStuffAndChecking v1");
    });
}
    app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
