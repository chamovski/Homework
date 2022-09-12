Console.WriteLine("Enter first number:");
var num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number:");
var num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Before swap first number = {num1} second number = {num2}." );
num1 = num1 + num2;      
num2 = num1 - num2;   
num1 = num1 - num2;    
Console.Write($"After swap first number = {num1} second number = {num2}.");