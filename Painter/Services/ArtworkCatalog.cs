using PittoreSite.Models;

namespace PittoreSite.Services;

public class ArtworkCatalog
{
    private readonly List<Artwork> _works =
    [
        new("laguna-alba", "לגונה, שחר", 2024, "שמן על פשתן", "120 × 160 ס״מ", "ונציה",
            "האור הראשון מעל הלגונה, כשהמים והשמיים עדיין לא נפרדו.", "#1F3A93", "#7FA7C9", "#E6E1D3", "4/3"),
        new("cortile", "חצר פנימית בסיינה", 2023, "שמן על בד", "90 × 90 ס״מ", "טוסקנה",
            "צל קר על קיר חם. נצבע במקום, בשלוש ישיבות.", "#7A4A2E", "#B08A5B", "#2E4A3E", "1/1"),
        new("terrazza", "טרסה בצהריים", 2023, "טמפרה ביצה על עץ", "60 × 80 ס״מ", "טוסקנה",
            "טמפרה מסורתית, שכבה על שכבה, עד שהחום נעצר בעץ.", "#C9A227", "#8C6B2F", "#E6E1D3", "4/3"),
        new("notturno", "נוקטורנו, קנאלה גראנדה", 2022, "שמן על פשתן", "100 × 140 ס״מ", "ונציה",
            "פנס בודד, השתקפות אחת, וכל השאר לפיס־לזולי.", "#0F1E4F", "#1F3A93", "#C9A227", "4/3"),
        new("ritratto-nonna", "סבתא אנה", 2021, "שמן על בד", "50 × 70 ס״מ", "דיוקנאות",
            "ישבה לי שלוש שעות ולא אמרה מילה. הציור אמר הכול.", "#3B2F2F", "#8E7B6B", "#D9D7C6", "5/7"),
        new("ulivi", "עצי זית, אחרי הגשם", 2020, "שמן על בד", "80 × 120 ס״מ", "טוסקנה",
            "כסף רטוב על אפור. הציור היחיד שלא מכרתי.", "#5C6B4A", "#9BA48A", "#6E6A63", "3/2"),
    ];

    public IReadOnlyList<Artwork> All => _works;

    public IEnumerable<string> Series => _works.Select(w => w.Series).Distinct();

    public Artwork? Find(string slug) => _works.FirstOrDefault(w => w.Slug == slug);
}
