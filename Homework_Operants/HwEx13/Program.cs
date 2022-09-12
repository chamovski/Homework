Console.WriteLine("Enter the amount of Celsius: ");
var temp = Convert.ToInt32(Console.ReadLine());

var kelvin = temp + 273;
var faren = ((temp * 9) / 5) + 32;

Console.WriteLine($"Kelvin = {kelvin}");
Console.WriteLine($"Fahrenheit = {faren}");