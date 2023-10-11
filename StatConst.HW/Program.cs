using System;

class Money
{
    private int dollars;
    private int cents;

    public Money(int dollars, int cents)
    {
        this.dollars = dollars;
        this.cents = cents;
    }

    public void PrintMoney()
    {
        Console.WriteLine($"Сума: {dollars} доларів і {cents} центів");
    }

    public void DecreasePrice(int amount)
    {
        dollars -= amount;
        if (dollars < 0)
        {
            dollars = 0;
        }
    }
}

class Product
{
    private string name;
    private Money price;

    public Product(string name, int dollars, int cents)
    {
        this.name = name;
        this.price = new Money(dollars, cents);
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Назва товару: {name}");
        price.PrintMoney();
    }

    public void DecreasePrice(int amount)
    {
        price.DecreasePrice(amount);
    }
}

class Device
{
    protected string name;
    protected string description;

    public Device(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public virtual void Sound()
    {
        Console.WriteLine("Звук пристрою");
    }

    public void Show()
    {
        Console.WriteLine($"Назва пристрою: {name}");
    }

    public void Desc()
    {
        Console.WriteLine($"Опис пристрою: {description}");
    }
}

class Kettle : Device
{
    public Kettle(string description) : base("Чайник", description) { }
}

class Microwave : Device
{
    public Microwave(string description) : base("Мікрохвильовка", description) { }
}

class Car : Device
{
    public Car(string description) : base("Автомобіль", description) { }
}

class Steamboat : Device
{
    public Steamboat(string description) : base("Пароплав", description) { }
}

class Program
{
    static void Main(string[] args)
    {
        Money money = new Money(100, 50);
        money.PrintMoney();

        Product product = new Product("Продукт", 50, 30);
        product.ShowInfo();

        Kettle kettle = new Kettle("Кухонний чайник");
        kettle.Sound();
        kettle.Show();
        kettle.Desc();
    }
}
