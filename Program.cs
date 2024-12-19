namespace Assignment_7._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ParkingSystem parkingSystem = new ParkingSystem(2, 0, 2); //Open Parking Spots: Big(1): 2 | Meduim(2): 0 | Small(3): 2

            Console.WriteLine(parkingSystem.AddCarToLot(1)); 
            Console.WriteLine(parkingSystem.AddCarToLot(2)); 
            Console.WriteLine(parkingSystem.AddCarToLot(3)); 
            Console.WriteLine(parkingSystem.AddCarToLot(1)); 
        }

    }
}
