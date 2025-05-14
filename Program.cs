SandwichShop shop = new SandwichShop();
Sandwich sandwich = shop.MakeSandwich();
Console.WriteLine(sandwich);

class SandwichShop
{
    private decimal Balance { get; }
    public SandwichShop()
    {
        Balance = 10000.00m;
    }

    private void GetListOfIngredients()
    {
        Console.WriteLine("----------BUNS----------");
        for (int i = 1; i < Enum.GetNames(typeof(Bun)).Length; i++)
        {
            Console.WriteLine($"{i}. {(Bun)i}");
        }

        Console.WriteLine("\n----------SPREADS----------");
        for (int i = 1; i < Enum.GetNames(typeof(Spread)).Length; i++)
        {
            Console.WriteLine($"{i}. {(Spread)i}");
        }

        Console.WriteLine("\n----------MEATS----------");
        for (int i = 1; i < Enum.GetNames(typeof(Meat)).Length; i++)
        {
            Console.WriteLine($"{i}. {(Meat)i}");
        }

        Console.WriteLine("\n----------CHEESES----------");
        for (int i = 1; i < Enum.GetNames(typeof(Cheese)).Length; i++)
        {
            Console.WriteLine($"{i}. {(Cheese)i}");
        }

        Console.WriteLine("\n----------VEGETABLES----------");
        for (int i = 1; i < Enum.GetNames(typeof(Vegetable)).Length; i++)
        {
            Console.WriteLine($"{i}. {(Vegetable)i}");
        }

        Console.WriteLine("\n----------SAUCES----------");
        for (int i = 1; i < Enum.GetNames(typeof(Sauce)).Length; i++)
        {
            Console.WriteLine($"{i}. {(Sauce)i}");
        }
    }

    public Sandwich MakeSandwich()
    {
        int bun, spread, meat, cheese, vegetable, sauce;
        Console.WriteLine("Hi, what can I get for you?");
        GetListOfIngredients();

        Console.WriteLine("What type of bun would you like?");
        bun = int.Parse(Console.ReadLine());
        Console.WriteLine("Nice, now pick your favourite spread, please.");
        spread = int.Parse(Console.ReadLine());
        Console.WriteLine("Good choice, time for a meat :).");
        meat = int.Parse(Console.ReadLine());
        Console.WriteLine("Cheese is a must have.");
        cheese = int.Parse(Console.ReadLine());
        Console.WriteLine("Some veggies?");
        vegetable = int.Parse(Console.ReadLine());
        Console.WriteLine("And a sauce for a finish");
        sauce = int.Parse(Console.ReadLine());

        return new Sandwich((Bun)bun, (Spread)spread, (Meat)meat, (Cheese)cheese, (Vegetable)vegetable, (Sauce)sauce);
    }
}

class Client
{
    private decimal Balance { get; }

    public Client()
    {
        Balance = 100.00m;
    }
}
record Sandwich(Bun bun, Spread spread, Meat meat, Cheese cheese, Vegetable vegetable, Sauce sauce);

enum Bun
{
    White_bread = 1,
    Ciabatta,
    Baguette,
    Kaiser_roll,
    English_muffin,
    Brioche,
    Bagel,
    Focaccia,
}

enum Spread
{
    Butter = 1,
    Cream_cheese,
    Guacamole,
    Almond_butter,
    Peanut_butter,
    Jam,
    Greek_yoghurt,
    Tapenade,
    None
}

enum Meat
{
    Ham = 1,
    Jamon,
    Prosciutto,
    Chicken,
    Turkey,
    Pork,
    Beef,
    Pepperoni,
    Hard_boiled_egg,
    Chorizo,
    Mortadela,
    Salami,
    None
}

enum Cheese
{
    Cheddar = 1,
    Edam,
    Gouda,
    Brie,
    Gorgonzola,
    Mozarella,
    Camembert,
    Blue_cheese,
    Swiss,
    Feta,
    Cottage_cheese,
    None
}

enum Vegetable
{
    Tomato = 1,
    Cucumber,
    Lettuce,
    Spinach,
    Radish,
    Green_onion,
    Pickles,
    Carrot,
    Onion,
    Red_onion,
    Cabbage,
    Rocket,
    Red_beans,
    White_beans,
    None
}

enum Sauce
{
    Ketchup = 1,
    Mustard,
    Mayonnaise,
    Thousand_islands,
    BBQ,
    Sweet_chili,
    Sriratcha,
    Danish,
    Garlic,
    Chipotle,
    Honey_mustard,
    Cranberry,
    None
}