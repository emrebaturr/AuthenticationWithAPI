var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddAuthentication();

var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name:"default",
    pattern:"{controller=Login}/{action=Index}"
    );
app.Run();
