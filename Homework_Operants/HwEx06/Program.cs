Console.WriteLine("Enter first number:");
var a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number:");
var b = Convert.ToInt32(Console.ReadLine());

var res1 = a + b;
var res2 = a - b;
var res3 = a * b;
var res4 = a / b; 
var res5 = a % b;

Console.WriteLine($"{a} + {b} = {res1}");
Console.WriteLine($"{a} - {b} = {res2}");
Console.WriteLine($"{a} * {b} = {res3}");
Console.WriteLine($"{a} / {b} = {res4}"); 
Console.WriteLine($"{a} mod {b} = {res5}");