using TestOpgave.Models;
using Newtonsoft.Json;

namespace TestOpgave.Services;

public class CarService
{
    
    public CarService()
    {
    }
    public List<Car> GetAllCars(string filePath)
    {
        List<Car> cars = new List<Car>();
        try
        {
            string json = File.ReadAllText(filePath);
            cars = JsonConvert.DeserializeObject<List<Car>>(json);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading JSON file: {ex.Message}");
        }
    
        return cars;
    }
}