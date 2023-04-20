using TestOpgave.Controllers;

static class Program
{
    public static void Main(string[] args)
    {
        CarController carController = new CarController();
        

        //Opgave 2
        Console.WriteLine("========================");
        Console.WriteLine("Opgave 2");
        var cars = carController.CarsOfEachBrandCount();
        foreach (KeyValuePair<string, int> kvp in cars)
        {
            Console.WriteLine($"Brand: {kvp.Key}, Count: {kvp.Value}");
        }
        Console.WriteLine("========================");
        Console.WriteLine("Opgave 3");
        //Opgave 3
        Console.WriteLine("Fords from after 1. Jan 1980: " + carController.GetAllFordsAfterDate());
        
        Console.WriteLine("========================");
        Console.WriteLine("Opgave 4");
        carController.AverageHPFromEachOrigin();
        
        Console.WriteLine("========================");
        Console.WriteLine("Opgave 5");
        
    }
}

