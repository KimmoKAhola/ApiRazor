using ApiRazor.KrisInfo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ApiRazor.Pages;

public class IndexModel : PageModel
{
    private readonly IHttpService<KrisInfoRoot> _service;
    private const int NumberOfDays = 365;
    public List<KrisInfoRoot> KrisInfo { get; set; } = new();
    public IndexModel(IHttpService<KrisInfoRoot> service)
    {
        _service = service;
    }

    public async Task<IActionResult> OnGet()
    {
        KrisInfo = await _service.GetAll(NumberOfDays);
        return Page();
    }
}