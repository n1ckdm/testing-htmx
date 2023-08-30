using Htmx;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace htmx_test.Pages;

[IgnoreAntiforgeryToken]
public class Counter : PageModel
{
    private static int Count = 0;

    public void OnGet()
    {
        Count = 0;
    }

    public IActionResult OnPost()
    {
        Count++;
        return Content($"{Count}", "text/html");
    }
}