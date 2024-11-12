// See https://aka.ms/new-console-template for more information
using LINQSamples;

Console.WriteLine("Hello, World!");

var customers = new CustomerService().GetCustomers();
var maxBudget = customers.Max(x => x.Budget);
var richCustomers = customers.Where(c => c.Budget == maxBudget);
Console.WriteLine($"{richCustomers.First().Name} {richCustomers.First().Budget}");
//yerine:
var realRich = customers.MaxBy(c => c.Budget);
Console.WriteLine($"{realRich.Name} {realRich.Budget}");
/*
 * MinBy
 * 
 */
Console.WriteLine("Çalışılan Ülkeler:");
var countriesDistinct = customers.DistinctBy(c => c.Country);
countriesDistinct.ToList().ForEach(c => Console.WriteLine(c.Name));

var numbers = Enumerable.Range(1, 15);
var countInNumbers = numbers.TryGetNonEnumeratedCount(out int count) ? count : 0;
Console.WriteLine($"Toplam eleman sayısı: {countInNumbers}");

var chunks = numbers.Chunk(size: 3);
foreach (var chunk in chunks)
{
    Console.WriteLine($"[{string.Join(",",chunk)}]");
}

Console.WriteLine($"Koleksiyonun ilk elemanı {numbers.ElementAt(0)}, sonu elemanı ise: {numbers.ElementAt(^1)}  ");
Console.WriteLine($"Koleksiyonun ilk üç elemanı  { string.Join(',', numbers.Take(0..3))}");
Console.WriteLine($"Koleksiyonun 6. indexten sonrası  {string.Join(',', numbers.Take(6..))}");
Console.WriteLine($"Koleksiyonun sondan 4. indexten sonrası  {string.Join(',', numbers.Take(^4..))}");


var firstOrNegative = numbers.FirstOrDefault(x => x > 15, -1);
var customer = customers.FirstOrDefault(c => c.Country == "Uganda", new Customer { Id = 0, Name = "Böyle bir müşteri yok" });

