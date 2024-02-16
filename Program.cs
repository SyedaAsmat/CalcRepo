// See https://aka.ms/new-console-template for more information

using CalcExample;

Calc calc = new Calc();
Console.WriteLine("Add call");
calc.Add(12, 45);
Console.WriteLine("Multi call");
calc.Multi(10.5, 12.45);
Console.WriteLine("Div call");
calc.Div(20, 4);
Console.WriteLine("Sub call");
calc.Sub(20, 4);
Console.WriteLine("Average call");
calc.Avg(13.5, 35.5);