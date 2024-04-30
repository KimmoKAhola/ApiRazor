using ApiRazor.KrisInfo;
using ApiRazor.RapidMovies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ApiRazor.Pages;

public class MoviesDetails : PageModel
{
    private readonly IHttpService<MoviesRoot> _service;
    public MoviesRoot Movie { get; set; }

    public MoviesDetails(IHttpService<MoviesRoot> service)
    {
        _service = service;
    }

    public async Task<IActionResult> OnGet(string id)
    {
        Movie = await _service.Get(id);
        return Page();
    }
}