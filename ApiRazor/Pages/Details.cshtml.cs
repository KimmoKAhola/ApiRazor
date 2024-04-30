using ApiRazor.KrisInfo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ApiRazor.Pages;

public class Details : PageModel
{
    private readonly IHttpService<KrisInfoRoot> _service;
    public KrisInfoRoot KrisInfoRoot { get; set; }

    public Details(IHttpService<KrisInfoRoot> service)
    {
        _service = service;
    }

    public async Task<IActionResult> OnGet(int id)
    {
        KrisInfoRoot = await _service.Get(id);
        return Page();
    }
}