SandwichShop shop = new SandwichShop();
Client client = new Client();
Sandwich sandwich = shop.OrderSandwich(client);
Console.WriteLine(sandwich);
Console.WriteLine($"Your balance: {client.Balance}");

class SandwichShop
{
    private decimal Balance { get; }
    private List<decimal> bunPrizes = new List<decimal> { 1.00m, 8.00m, 4.00m, 0.80m, 5.00m, 11.50m, 3.00m, 10.00m};
    private List<decimal> spreadPrizes = new List<decimal> { 1.00m, 3.00m, 6.00m, 8.00m, 3.50m, 1.00m, 5.00m, 0.00m};
    private List<decimal> meatPrizes = new List<decimal> { 1.00m, 8.00m, 6.00m, 5.50m, 5.50m, 7.50m, 9.00m, 4.00m, 6.50m, 6.50m, 3.00m, 0.00m};
    private List<decimal> cheesePrizes = new List<decimal> { 7.00m, 4.00m, 2.50m, 8.00m, 10.00m, 5.30m, 6.00m, 6.10m, 4.00m, 10.10m, 2.50m, 0.00m};
    private List<decimal> vegetablePrizes = new List<decimal> { 2.20m, 3.00m, 0.60m, 4.00m, 0.70m, 1.50m, 1.80m, 0.50m, 0.30m, 0.50m, 4.00m, 1.00m, 1.20m, 0.00m};
    private List<decimal> saucePrizes = new List<decimal> { 2.50m, 2.00m, 4.00m, 5.00m, 5.00m, 5.50m, 6.00m, 7.00m, 5.50m, 5.00m, 7.50m, 3.50m, 6.00m};
    public SandwichShop()
    {
        Balance = 10000.00m;
    }

    private void GetListOfIngredients()
    {
        Console.WriteLine("----------BUNS----------");
        for (int i = 1; i < Enum.GetNames(typeof(Bun)).Length; i++)
        {
            Console.WriteLine($"{i}. {(Bun)i} {bunPrizes[i-1]}zł");
        }

        Console.WriteLine("\n----------SPREADS----------");
        for (int i = 1; i < Enum.GetNames(typeof(Spread)).Length; i++)
        {
            Console.WriteLine($"{i}. {(Spread)i} {spreadPrizes[i - 1]}zł");
        }

        Console.WriteLine("\n----------MEATS----------");
        for (int i = 1; i < Enum.GetNames(typeof(Meat)).Length; i++)
        {
            Console.WriteLine($"{i}. {(Meat)i} {meatPrizes[i - 1]}zł");
        }

        Console.WriteLine("\n----------CHEESES----------");
        for (int i = 1; i < Enum.GetNames(typeof(Cheese)).Length; i++)
        {
            Console.WriteLine($"{i}. {(Cheese)i} {cheesePrizes[i - 1]}zł");
        }

        Console.WriteLine("\n----------VEGETABLES----------");
        for (int i = 1; i < Enum.GetNames(typeof(Vegetable)).Length; i++)
        {
            Console.WriteLine($"{i}. {(Vegetable)i} {vegetablePrizes[i - 1]}zł");
        }

        Console.WriteLine("\n----------SAUCES----------");
        for (int i = 1; i < Enum.GetNames(typeof(Sauce)).Length; i++)
        {
            Console.WriteLine($"{i}. {(Sauce)i} {saucePrizes[i - 1]}zł");
        }
    }

    public Sandwich OrderSandwich(Client client)
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

        client.Balance = client.Balance - bunPrizes[bun - 1]
            - spreadPrizes[spread - 1] - meatPrizes[meat - 1] - cheesePrizes[cheese - 1] - vegetablePrizes[vegetable - 1] - saucePrizes[sauce - 1];

    Console.WriteLine($"That's the chad sandwich that you have composed there! It'il cost: {bunPrizes[bun-1]
            + spreadPrizes[spread-1] + meatPrizes[meat-1] + cheesePrizes[cheese-1] + vegetablePrizes[vegetable-1] + saucePrizes[sauce-1]}");

        return new Sandwich((Bun)bun, (Spread)spread, (Meat)meat, (Cheese)cheese, (Vegetable)vegetable, (Sauce)sauce);
    }
}

class Client
{
    public decimal Balance { get; set; }

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