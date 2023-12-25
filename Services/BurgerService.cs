using BigEBurgers.Models;

namespace BigEBurgers.Services;

public static class BurgerService
{
    static List<Burger> Burgers { get; }
    static int nextId = 4;
    static BurgerService()
    {
        Burgers = new List<Burger>
        {
            new Burger {Id = 1, Name = "Classic BigE Burger", Condiments = new List<Condiments>{new Condiments{HasKetchup=true, HasMayonnaise=true}}, Ingredients = new List<Ingredients> {new Ingredients{HasLettuce=true, HasTomatoes=true, HasPickles=true, Cheese="American"}}},
            new Burger {Id = 2, Name = "VegE Burger", Condiments = new List<Condiments>{new Condiments{HasMustard=true, HasKetchup=true}}, Ingredients = new List<Ingredients>{new Ingredients{HasLettuce=true, HasPickles=true, HasTomatoes=true, Cheese="Vegan Cheese"}}},
            new Burger {Id = 3, Name = "BigE Small Burger", Condiments = new List<Condiments>{new Condiments{HasBarbequeSauce=true}}, Ingredients = new List<Ingredients>{new Ingredients{HasMushrooms=true, Cheese="Swiss"}}}
        };
    }

    public static List<Burger> GetAll() => Burgers;
    public static Burger? Get(int id) => Burgers.FirstOrDefault(b => b.Id == id);
    public static void Add(Burger burger)
    {
        burger.Id = nextId++;
        Burgers.Add(burger);
    }
    public static void Delete(int id)
    {
        var burger = Get(id);
        if(burger is null) return;

        Burgers.Remove(burger);
    }
    public static void Update(Burger burger)
    {
        var index = Burgers.FindIndex(b => b.Id == burger.Id);
        if(index == -1) return;

        Burgers[index] = burger;
    }
}