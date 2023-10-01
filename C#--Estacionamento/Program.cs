

using C___Estacionamento;

Estacionamento esta = new Estacionamento();

esta.ActiveSystem = true;

esta.StartPrice = 0;
esta.HourPrice = 0;
string licensePlate = "";

Console.WriteLine("Welcome to parking lot! \n" +
    "Enter the value: ");
esta.StartPrice = Convert.ToDecimal(Console.ReadLine());

while (esta.ActiveSystem) 
{
    Console.WriteLine("1 - Register");
    Console.WriteLine("2 - Remove");
    Console.WriteLine("3 - List Vehicle");
    Console.WriteLine("4 - Exit");
    
    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("Enter the license plate");
            licensePlate = Convert.ToString(Console.ReadLine());
            esta.addVehicle(licensePlate);
            Console.WriteLine($"Register success! ");
            break;
        case "2":
            Console.WriteLine("Enter the license plate");
            licensePlate = Convert.ToString(Console.ReadLine());
            esta.removeVehicle(licensePlate);
            Console.WriteLine("Now price hour: ");
            esta.HourPrice = Convert.ToDecimal(Console.ReadLine());
            decimal price = 0;
            price = esta.StartPrice * esta.HourPrice;
            Console.WriteLine($"amount to be paid: {price}$");
            Console.WriteLine($"Remove success! ");
            break;
        case "3":
            Console.WriteLine("number of vehicles licensePlate");
            esta.listVehicle();
            break;
        case "4":
            esta.ActiveSystem = false;
            break;
        default:
            Console.WriteLine("Wrong choice");
            break;
    }
}