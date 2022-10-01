using CSTP2104_A1;

public class Program
{
    static void Main(string[] args)
    {
        Car sellingCar = new Car();
        var colourCar = (Colour)3;

        sellingCar.Price = 30000;
        sellingCar.Make = "Ford";
        sellingCar.Model = "F-150";
        sellingCar.Year = 2009;
        sellingCar.Kilometres = "50000km";
        sellingCar.Trim = "Standard";
        sellingCar.VehicleType = "Truck";
        sellingCar.Engine = "2.7L V6";
        sellingCar.Cylinders = 6;
        sellingCar.Transmission = "Automatic";
        sellingCar.Drivetrain = "FWD";
        sellingCar.Stocknumber = "1A9L2F";
        sellingCar.Doors = 4;
        sellingCar.Fuel = "60L";


        Console.WriteLine("Price = {0} " +
                          "Make = {1} " +
                          "Kilometres = {2} " +
                          "Model = {3} " +
                          "Year = {4} " +
                          "Trim = {5} " +
                          "VehicleType = {6} " +
                          "Engine = {7} " +
                          "Cylinders = {8} " +
                          "Transmission = {9} " +
                          "Drive train = {10} " +
                          "Stocknumber = {11} " +
                          "Doors = {12} " +
                          "Fuel = {13} " +
                          "Car colour = {14} " , 

        sellingCar.Price,
        sellingCar.Make,
        sellingCar.Kilometres,
        sellingCar.Model,
        sellingCar.Year,
        sellingCar.Trim,
        sellingCar.VehicleType,
        sellingCar.Engine,
        sellingCar.Cylinders,
        sellingCar.Transmission,
        sellingCar.Drivetrain,
        sellingCar.Stocknumber,
        sellingCar.Doors,
        sellingCar.Fuel,
        colourCar
        );



        Boat sellingBoat = new Boat();
        var colourBoat = (Colour)7;


        sellingBoat.Price = 100000;
        sellingBoat.Trim = "Luxury";
        sellingBoat.Loa = 15;
        sellingBoat.Model = "Fridgette Cruiseliner";
        sellingBoat.Propulsion = "Two F2 Motors";
        sellingBoat.Fuel = "Diesel";
        sellingBoat.DryWeight = 9000;
        sellingBoat.FreshWaterC = "80L";
        sellingBoat.BlackWaterC = "60L";


        Console.WriteLine("Price = {0} " +
                          "Trim = {1} " +
                          "Loa = {2} " +
                          "Model = {3} " +
                          "Propulsion = {4} " +
                          "Fuel = {5} " +
                          "Dryweight = {6} " +
                          "Fresh Water Capacity = {7} " +
                          "Black Water Capactiy = {8} " +
                          "Boat colour = {9} ",

        sellingBoat.Price,
        sellingBoat.Trim,
        sellingBoat.Loa,
        sellingBoat.Model,
        sellingBoat.Propulsion,
        sellingBoat.Fuel,
        sellingBoat.DryWeight,
        sellingBoat.FreshWaterC,
        sellingBoat.BlackWaterC,
        colourBoat
        );


        Trailer sellingTrailer = new Trailer();
        var colourTrailer = (Colour)9;

        sellingTrailer.Price = 69000;
        sellingTrailer.Trim = "Standard+";
        sellingTrailer.Model = "Skyridge Fam2000";
        sellingTrailer.Fuel = "Gas and propane";
        sellingTrailer.Kilometres = "60000km";
        sellingTrailer.Engine = "V8 Twin Turbo";
        sellingTrailer.TrailerWarranty = "72 MONTH GOLD STAR TRANSFERABLE EXTENDED WARRANTY ";
                                            
        sellingTrailer.hasHitch = true;
        sellingTrailer.ulVehicleWeight = 7000;
        sellingTrailer.winterized = false;

        Console.WriteLine("Price = {0} " + 
                          "Trim = {1} " +
                          "Model = {2} " +
                          "Fuel = {3} " +
                          "Kilometres = {4} " +
                          "Engine = {5} " +
                          "Trailer Descscription {6} " +
                          "Has a hitch {7} " + 
                          "Unloaded vehicle weight {8} " +
                          "Winterized {9} " +
                          "Colour Car = {10} " ,

        sellingTrailer.Price,
        sellingTrailer.Trim,
        sellingTrailer.Model,
        sellingTrailer.Fuel,
        sellingTrailer.Kilometres,
        sellingTrailer.Engine,
        sellingTrailer.TrailerWarranty,
        sellingTrailer.hasHitch,
        sellingTrailer.ulVehicleWeight,
        sellingTrailer.winterized,
        colourTrailer
        );
        
        Customer c1 = new Customer();
        Console.Write("Enter your first name: ");
        c1.Name = Console.ReadLine();
        Console.Write("Enter your email: ");
        c1.Email = Console.ReadLine();
        Console.WriteLine("Contact information for seller:");
        Console.WriteLine("Customer Name: {0}", c1.Name);
        Console.WriteLine("Customer Email: {0}", c1.Email);

    }

}