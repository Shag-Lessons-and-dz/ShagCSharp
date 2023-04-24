using System;

namespace dz6
{
    class Shop
{
    private int number;
    private int code;
    private string name;
    private string unit;
    private decimal priceOld;
    private decimal priceNew;

    private static int countObjects;

    static Shop()
    {
        countObjects = 0;
    }

    public Shop()
    {
        number = 0;
        code = 0;
        name = "";
        unit = "";
        priceOld = 0;
        priceNew = 0;
        countObjects++;
    }

    public Shop(int number, int code, string name, string unit, decimal priceOld, decimal priceNew)
    {
        this.number = number;
        this.code = code;
        this.name = name;
        this.unit = unit;
        this.priceOld = priceOld;
        this.priceNew = priceNew;
        countObjects++;
    }

    public Shop(int number, int code, string name)
    {
        this.number = number;
        this.code = code;
        this.name = name;
        unit = "";
        priceOld = 0;
        priceNew = 0;
        countObjects++;
    }

    public void GetFields(out int number, out int code, out string name, out string unit, out decimal priceOld, out decimal priceNew)
    {
        number = this.number;
        code = this.code;
        name = this.name;
        unit = this.unit;
        priceOld = this.priceOld;
        priceNew = this.priceNew;
    }

    public void SetFields(int number, int code, string name, string unit, decimal priceOld, decimal priceNew)
    {
        this.number = number;
        this.code = code;
        this.name = name;
        this.unit = unit;
        this.priceOld = priceOld;
        this.priceNew = priceNew;
    }

    public void ChangePrice(decimal delta)
    {
        priceNew -= delta;
    }

    public void Print()
    {
        Console.WriteLine("Number: " + number);
        Console.WriteLine("Code: " + code);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Unit: " + unit);
        Console.WriteLine("Price Old: " + priceOld);
        Console.WriteLine("Price New: " + priceNew);
    }

    public static void Input(ref Shop shop)
    {
        int number, code;
        string name, unit;
        decimal priceOld, priceNew;

        Console.Write("Enter number: ");
        number = int.Parse(Console.ReadLine());

        Console.Write("Enter code: ");
        code = int.Parse(Console.ReadLine());

        Console.Write("Enter name: ");
        name = Console.ReadLine();

        Console.Write("Enter unit: ");
        unit = Console.ReadLine();

        Console.Write("Enter price old: ");
        priceOld = decimal.Parse(Console.ReadLine());

        Console.Write("Enter price new: ");
        priceNew = decimal.Parse(Console.ReadLine());

        shop = new Shop(number, code, name, unit, priceOld, priceNew);
    }

    public static int GetCountObjects()
    {
        return countObjects;
    }
}

    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Shop[] shops = new Shop[3];

            for (int i = 0; i < 3; i++)
            {
                Shop.Input(ref shops[i]);
            }

            Console.WriteLine("Count of objects created: " + Shop.GetCountObjects());
            
            for (int i = 0; i < 3; i++)
            {
                shops[i].Print();
            }
        }

        }
    }