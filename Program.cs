SandwichShop shop = new SandwichShop();
shop.GetListOfIngredients();

class SandwichShop
{
    private decimal Balance { get; }
    public SandwichShop()
    {
        Balance = 10000.00m;
    }

    public void GetListOfIngredients()
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

    //public Sandwich MakeSandwich()
    //{
    //    GetListOfIngredients();
    //}
}

class Client
{
    private decimal Balance { get; }

    public Client()
    {
        Balance = 100.00m;
    }
}
record Sandwich(string bun, string spread, string main, string vegetable, string sauce);

enum Bun
{
    White_bread = 1,
    Ciabatta,
    Baguette,
    Kaiser_roll,
    English_muffin,
    Brioche,
    Bagel,
    Focaccia
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
    Salami
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
    Cottage_cheese
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
    White_beans
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
    Cranberry
}