Console.WriteLine("Enter your desired temperature unit to witch you would like to convert: (c/f) ");
char userTempSystem = char.Parse(Console.ReadLine());

Console.WriteLine("Enter your current temperature");
char userTemp = char.Parse(Console.ReadLine());



if (userTempSystem == 'c')  
{
    ConvertToCelsius();
}
else 
{
    ConvertToFahrenheit();
}

static void ConvertToCelsius(string newTemp)
{
    Console.WriteLine($"{newTemp} -32 / (5/9)");
}

static void ConvertToFahrenheit(string newTemp) 
{
    Console.WriteLine($"{newTemp} * 9/(5+32)");
}

string newTemp;