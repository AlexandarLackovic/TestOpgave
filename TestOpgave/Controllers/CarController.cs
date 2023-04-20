using TestOpgave.Services;
using TestOpgave.Models;

namespace TestOpgave.Controllers;

public class CarController
{
    private List<Car> _cars;
    private CarService _carService;

    public CarController()
    {
        _carService = new CarService();
        _cars = _carService.GetAllCars("../../../Data/cars.json");
    }

    public Dictionary<string, int> CarsOfEachBrandCount()
    {
        Dictionary<string, int> carCounts = new Dictionary<string, int>();

        try
        {
            foreach (Car car in _cars)
            {
                string brand = car.Name.Split(' ')[0];
                if (carCounts.ContainsKey(brand))
                {
                    carCounts[brand]++;
                }
                else
                {
                    carCounts.Add(brand, 1);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
        }

        return carCounts;
    }

    public int GetAllFordsAfterDate()
    {
        var fordCount = new int();
        try
        {
            fordCount = _cars.Count(c => c.Name.ToLower().StartsWith("ford") && c.Year > new DateTime(1980, 1, 1));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
        }

        return fordCount;
    }

    public void AverageHPFromEachOrigin()
    {
        try
        {
            var averageHorsepowerByOrigin = _cars
                .GroupBy(c => c.Origin)
                .Select(g => new { Origin = g.Key, AverageHorsepower = g.Average(c => c.Horsepower) });

            foreach (var item in averageHorsepowerByOrigin)
            {
                Console.WriteLine($"{item.Origin}: {item.AverageHorsepower} HP");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
        }
    }
}