

public static class Car
{
    public string Name { get; set; };
    private string color;

    public string Color 
    { 
        get { return color} ; 
        set { color = value} ; 
    };
    public double Price { get; set; };
    public readonly string CompanyName;

    public void InputData ()
{
    Console.WriteLine("Enter car name: ");
    Name = Console.ReadLine();

    Console.WriteLine("Enter car color: ");
    Color = Console.ReadLine(); 

    Console.WriteLine("Enter car price: ");
    Price = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter car company name: ");
    CompanyName = Console.ReadLine(); 
}
    public Car()   
    { 
        Name = "Ford Mustang"; 
        Color = "black"; 
        Price = 18000; 
        CompanyName = "Ford";
    }

    public Car(string name, string color, double price, string companyName)
    {
        Name = name;
        Color = color;
        Price = price;
        CompanyName = companyName; 
    }
}

