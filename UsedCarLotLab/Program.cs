using UsedCarLotLab;

List<Car> cars = new List<Car>();

Car carOne = new Car("Honda", "Civic", 2022, 25000.00m);
Car carTwo = new Car("Ford", "Bronco", 2022, 40000.00m);
Car carThree = new Car("Dodge", "TRX", 2022, 100000.00m);
UsedCar carFour = new UsedCar("Dodge", "Raider", 1988, 2500.00m, 185000);
UsedCar carFive = new UsedCar("Mazda", "Speed6", 1978, 25400.00m, 1850400);
UsedCar carSix = new UsedCar("Tesla", "X", 2020, 25000.00m, 15000);
cars.Add(carOne);
cars.Add(carTwo);
cars.Add(carThree);
cars.Add(carFour);
cars.Add(carFive);
cars.Add(carSix);

int selectionNum = 1;

foreach(Car car in cars)
{
    Console.WriteLine($"\nSELECTION #{selectionNum}");
    Console.WriteLine(car.ToString());
    selectionNum++;
}

Waypoint1:

Console.WriteLine("\nPLEASE ENTER YOUR SELECTION:");
string input = Console.ReadLine();
try
{
    int selectionInt = Int32.Parse(input);
    int carIndex = selectionInt - 1;
    Console.Clear();
    Console.WriteLine($"YOU SELECTED CAR #{input}");
    Console.WriteLine(cars[carIndex].ToString());
}
catch (FormatException)
{
    Console.WriteLine("INVALID INPUT! PLEASE ENTER A NUMBER.");
    goto Waypoint1;
}

Console.WriteLine("\nWOULD YOU LIKE TO PURCHASE THIS CAR?");


