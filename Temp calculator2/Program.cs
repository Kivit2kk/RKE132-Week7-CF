Console.WriteLine("Enter your desired temperature unit to witch you would like to convert: (C/F) ");
char userTempSystem = char.Parse(Console.ReadLine());

Console.WriteLine("Enter your temperature");
string userTemp = int.Parse(Console.ReadLine());

switch (userTempSystem) 
{
    case 'C':
        Console.WriteLine(convertedToCelsius);
        break;
    case 'F':
        Console.WriteLine(convertedToFahrenheit);
        break;
    default:
        Console.WriteLine("Wrong input");
        break;
}

static void convertedToCelsius ()
{
{userTemp} - 32 * (5 / 9);
}
