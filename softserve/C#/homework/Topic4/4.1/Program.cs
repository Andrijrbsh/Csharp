class Program
{
    static void Main(string[] args)
    {
        Car Tesla = new Car("Tesla Model S", "Red", 79999, "Tesla");
        Car Honda = new Car("Honda S", "Black", 24999, "Honda");
        Car Toyota = new Car("Toyota L", "White", 34999, "Toyota");

        Toyota.Print();
    }

    public class Car
    {
        public string Name { get; set; }
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public double Price { get; set; }
        public readonly string CompanyName;

        public void InputData()
        {
            Console.WriteLine("Enter car name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter car color: ");
            Color = Console.ReadLine();

            Console.WriteLine("Enter car price: ");
            Price = Convert.ToDouble(Console.ReadLine());

            // CompanyName can only be set in the constructor, as it is readonly
        }

        public void Print()
        {
            System.Console.WriteLine("Name: {0}, Color: {1}, Price: {2}, Company Name: {3}", Name, Color, Price, CompanyName);
        }

        public void ChangePrice(double x)
        {
            Price = Price * (1 + x / 100);
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
}
