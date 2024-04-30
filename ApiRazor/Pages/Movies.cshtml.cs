using ApiRazor.KrisInfo;
using ApiRazor.RapidMovies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ApiRazor.Pages;

public class Movies : PageModel
{
    private readonly IHttpService<MoviesRoot> _service;
    public MoviesRoot ListOfMovies { get; set; }

    public Movies(IHttpService<MoviesRoot> service)
    {
        _service = service;
    }

    public async Task<IActionResult> OnGet()
    {
        ListOfMovies = await _service.GetAll();
        return Page();
    }
}