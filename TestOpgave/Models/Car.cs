using System.Text.Json.Serialization;

namespace TestOpgave.Models;

//Opgave 1
public class Car
{
    public string Name { get; set; }
    public double MilesPerGallon { get; set; }
    public int Cylinders { get; set; }
    public double Displacement { get; set; }
    public double? Horsepower { get; set; }
    public int WeightInLbs { get; set; }
    public double Acceleration { get; set; }
    public DateTime Year { get; set; }
    public string Origin { get; set; }
    public double KilometerPerLiter { get; private set; }

    public Car(string name, double milesPerGallon, int cylinders, double displacement, double? horsepower, int weightInLbs, double acceleration, DateTime year, string origin)
    {
        Name = name;
        MilesPerGallon = milesPerGallon;
        Cylinders = cylinders;
        Displacement = displacement;
        Horsepower = horsepower;
        WeightInLbs = weightInLbs;
        Acceleration = acceleration;
        Year = year;
        Origin = origin;

        CalculateKilometerPerLiter();
    }

    private void CalculateKilometerPerLiter()
    {
        const double kilometersPerMile = 1.6;
        const double litersPerGallon = 3.79;

        if (MilesPerGallon != 0)
        {
            KilometerPerLiter = (kilometersPerMile * litersPerGallon) / MilesPerGallon;
        }
    }
}
