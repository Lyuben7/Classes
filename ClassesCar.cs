using System;
using System.Collections.Generic;

public class Class1
{
    private string brand;
    private string model;
    private int horsePower;

    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    } 
    public string Model
    {
        get { return model; }
        set { model = value; }
    } 
    public string HorsePower
    {
        get { return horsePower; }
        set { horsePower = value; }
    }

    public string CarInfo()
    {
        return $"The car is: {brand} {model} - {horsePower} HP."; 
    }

    public class CarInfo
    {
        public static void Main()
        {
            int n = int.Parse(Console.Readline());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                Car car = new Car
                {
                    Brand = carInfo[0],
                    Model = carInfo[1],
                    HorsePower = int.Parse(carInfo[2])
                };
                cars.Add(car);
            }
            foreach (var car in cars)
            {
                Console.WritLine(car.CarInfo());
            }
        }
    }
}
