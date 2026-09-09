using Microsoft.AspNetCore.Mvc.RazorPages;
using PittoreSite.Models;
using PittoreSite.Services;

namespace PittoreSite.Pages;

public class IndexModel(ArtworkCatalog catalog) : PageModel
{
    public Artwork Hero { get; private set; } = default!;
    public IEnumerable<Artwork> Selected { get; private set; } = [];

    public void OnGet()
    {
        Hero = catalog.All[0];
        Selected = catalog.All.Skip(1).Take(3);
    }
}
