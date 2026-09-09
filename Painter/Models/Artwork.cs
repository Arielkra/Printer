namespace PittoreSite.Models;

public record Artwork(
    string Slug,
    string Title,
    int Year,
    string Medium,
    string Size,
    string Series,
    string Description,
    string ColorA,
    string ColorB,
    string ColorC,
    string Ratio);
