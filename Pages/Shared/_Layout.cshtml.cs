namespace htmx_test.Pages;
public record NavItem(string Text, string Url);
public record FoodResult(bool IsSelected = false, string? Food = null);