namespace BigEBurgers.Models;

public class Burger
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public List<Ingredients>? Ingredients { get; set; }
    public List<Condiments>? Condiments { get; set; }
}

public class Condiments
{
    public bool HasMustard { get; set; } = false;
    public bool HasKetchup { get; set; } = false;
    public bool HasMayonnaise { get; set; } = false;
    public bool HasBarbequeSauce { get; set; } = false;
}

public class Ingredients
{
    public bool HasPickles { get; set; } = false;
    public bool HasTomatoes { get; set; } = false;
    public bool HasLettuce { get; set; } = false;
    public bool HasMushrooms { get; set; } = false;
    public bool HasJalapenos { get; set; } = false;
    public string? Cheese { get; set; } = "";
}