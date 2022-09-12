Console.WriteLine("Enter first number:");
var num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number:");
var num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number:");
var num3 = Convert.ToInt32(Console.ReadLine());

var res = num1 * num2 * num3;
Console.WriteLine($"Multiplication of {num1} x {num2} x {num3} = {res}.");