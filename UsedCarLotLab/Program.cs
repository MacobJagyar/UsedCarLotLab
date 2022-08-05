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

CarLot.PrintAllCars(cars, selectionNum);

Console.Write("\nWould you like to PURCHASE a car or SELL us a car? ");
string buySellChoice = Console.ReadLine().ToLower();

if (buySellChoice == "purchase")
{
    goto Waypoint1;
}
else if (buySellChoice == "sell")
{
    UsedCar newCar = new UsedCar();
    CarLot.AddCar(cars, newCar);
    CarLot.PrintAllCars(cars, selectionNum);

    Console.WriteLine("\nThanks! Wanna look at the lot? Y/N");
    string lotChoice = Console.ReadLine().ToLower();
    
    if (lotChoice == "y")
    {
        CarLot.PrintAllCars(cars, selectionNum);
        goto Waypoint1;
    } 
    else if (lotChoice == "n")
    {
        Console.WriteLine("See you later!");
        Environment.Exit(0);
    }
}

Waypoint1:

Console.WriteLine("\nPLEASE ENTER YOUR SELECTION:");
string input = Console.ReadLine();

int carIndex = 0;
try
{
    int selectionInt = Int32.Parse(input);
    carIndex = selectionInt - 1;
    if (carIndex > 0 && carIndex <= cars.Count)
    {
        Console.Clear();
        Console.WriteLine($"YOU SELECTED CAR #{input}");
        Console.WriteLine(cars[carIndex].ToString());
    }
    else
    {
        Console.WriteLine("INVALID INPUT!");
        goto Waypoint1;
            
    }
}
catch (FormatException)
{
    Console.WriteLine("INVALID INPUT! PLEASE ENTER A NUMBER.");
    goto Waypoint1;
}



Console.WriteLine("\nWOULD YOU LIKE TO PURCHASE THIS CAR? Y/N");
string purchaseInput = Console.ReadLine().ToLower();

if (purchaseInput == "y")
{
    Console.Clear();
    Console.WriteLine("\nGreat! Enjoy your new car!");
    CarLot.RemoveCar(cars, cars[carIndex]);
    CarLot.PrintAllCars(cars, selectionNum);
    goto Waypoint1;
}
else if (purchaseInput == "n")
{
    Console.Clear();
    Console.WriteLine("Changed your mind? Here's the car list again! ");
    CarLot.PrintAllCars(cars, selectionNum);
    goto Waypoint1;
}


