Console.WriteLine("Enter first number:");
var x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number:");
var y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number:");
var z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Result of specified numbers {x} , {y} , {z} (x + y) * z is {(x + y) * z} and (x * y) + (y * z) is {(x * y) + (y * z)}");