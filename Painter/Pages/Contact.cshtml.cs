using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PittoreSite.Pages;

public class ContactModel : PageModel
{
    [BindProperty] public ContactForm Form { get; set; } = new();
    [TempData] public bool Sent { get; set; }

    public void OnGet(string? work)
    {
        if (!string.IsNullOrEmpty(work))
            Form.Message = $"שלום, אשמח לשמוע פרטים על העבודה ״{work}״.";
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid) return Page();

        // כאן מחברים שליחת מייל / שמירה במסד נתונים.
        Sent = true;
        return RedirectToPage();
    }

    public class ContactForm
    {
        [Required(ErrorMessage = "יש להזין שם")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "יש להזין כתובת מייל"), EmailAddress(ErrorMessage = "כתובת מייל לא תקינה")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "יש לכתוב הודעה"), MaxLength(2000)]
        public string Message { get; set; } = "";
    }
}
