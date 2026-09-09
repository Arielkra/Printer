using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PittoreSite.Models;
using PittoreSite.Services;

namespace PittoreSite.Pages;

public class GalleryModel(ArtworkCatalog catalog) : PageModel
{
    [BindProperty(SupportsGet = true)] public string? Series { get; set; }
    [BindProperty(SupportsGet = true)] public string? Slug { get; set; }

    public IEnumerable<string> AllSeries => catalog.Series;
    public IEnumerable<Artwork> Works { get; private set; } = [];
    public Artwork? Detail { get; private set; }

    public IActionResult OnGet()
    {
        if (!string.IsNullOrEmpty(Slug))
        {
            Detail = catalog.Find(Slug);
            if (Detail is null) return NotFound();
        }

        Works = string.IsNullOrEmpty(Series)
            ? catalog.All
            : catalog.All.Where(w => w.Series == Series);
        return Page();
    }
}
