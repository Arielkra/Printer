# אתר צייר – מתאו רינאלדי (ASP.NET Core Razor Pages, .NET 8)

## הרצה
    dotnet run

## מבנה
- Pages/Index          – דף בית (עבודה ראשית + עבודות נבחרות)
- Pages/Gallery        – גלריה עם סינון לפי סדרה, ודף עבודה בודדת (/works/{slug})
- Pages/About          – על הצייר ותערוכות
- Pages/Contact        – טופס יצירת קשר עם ולידציה (OnPost)
- Services/ArtworkCatalog.cs – רשימת העבודות (להחליף בתמונות אמיתיות / DB)
- wwwroot/css/site.css – עיצוב

## להוסיף תמונות אמיתיות
הוסיפו שדה ImageUrl ל-Artwork, ובמקום ה-div.canvas ב-_Canvas.cshtml
הציגו <img src="@Model.ImageUrl" alt="@Model.Title" />.
