using Microsoft.OpenApi.Models;
using SwaggerDITest.Algorythms.Interface;
using SwaggerDITest.Algorythms;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IBubbleSort, BubbleSort>();
builder.Services.AddScoped<IInsertionSort, InsertionSort>();
builder.Services.AddScoped<IMergeSort, MergeSort>();
builder.Services.AddScoped<IQuickSort, QuickSort>();
builder.Services.AddScoped<ISelectionSort, SelectionSort>();
builder.Services.AddScoped<ITreeSort, TreeSort>();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "SortingInts", Version = "v1" });
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

builder.Services.AddControllers();
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "SortingInts v1");
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