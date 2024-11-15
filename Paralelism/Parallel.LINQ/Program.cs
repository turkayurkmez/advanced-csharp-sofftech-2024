// See https://aka.ms/new-console-template for more information

var maxNumber = 20000000;
var numbers = Enumerable.Range(1, maxNumber).ToList();

var multiplyThrees = numbers.AsParallel().Where(p => p % 3 == 0);
var totalNumbers = multiplyThrees.Count();
Console.WriteLine($"üçün katları {totalNumbers} adet var");