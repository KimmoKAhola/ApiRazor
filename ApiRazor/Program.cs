using System.Net.Http.Headers;
using ApiRazor;
using ApiRazor.KrisInfo;
using ApiRazor.RapidMovies;
using ApiRazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddHttpClient<IHttpService<KrisInfoRoot>, KrisInfoHttpService>(o =>
{
    o.BaseAddress = new Uri("https://api.krisinformation.se/v3/news/");
});

builder.Services.AddHttpClient<IHttpService<MoviesRoot>, RapidMoviesHttpService>(o =>
{
    o.BaseAddress = new Uri("https://moviesdatabase.p.rapidapi.com/");
    o.DefaultRequestHeaders.Add("X-RapidAPI-Key", "f2450c21e0msh2817565f5d43cf9p136178jsnff6f2200bc40");
    o.DefaultRequestHeaders.Add("X-RapidAPI-Host", "moviesdatabase.p.rapidapi.com");
});
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