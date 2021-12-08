using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Rcrud.Server;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<Db>(opcije =>
{
    opcije.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Teest;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    //("Server=localhost;Database=NovaDb;Uid=root;Pwd='';", ServerVersion.AutoDetect("Server = localhost; Database = NovaDb; Uid = root; Pwd = '';"));
});
builder.Services.AddSignalR();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
}

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.MapHub<OsobeHub>("osobe");
app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
