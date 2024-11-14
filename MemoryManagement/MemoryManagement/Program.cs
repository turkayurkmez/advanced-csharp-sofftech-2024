// See https://aka.ms/new-console-template for more information
//var start =
using MemoryManagement;
using System.Security.Cryptography;
using System.Text;

Console.WriteLine($"Sistem boştayken: {GC.GetTotalMemory(true)} byte.");
Random random = new Random();
Console.WriteLine($"Random instance'ı: {GC.GetTotalMemory(true)} byte.");

int number = random.Next();
Console.WriteLine($"Sayı üretildi: {GC.GetTotalMemory(true)} byte.");
//Console.WriteLine( "801" );
//var final = GC.GetTotalMemory(true);
int primitive = 7284;
Console.WriteLine($"primitif tip: {GC.GetTotalMemory(true)} byte.");

var complex = new Product { Id = 1, Name = "Pantolon", Category = new Category { Name = "Giyim" } };
random.NextBytes(complex.ProductImage);

Console.WriteLine($"kompleks tip: {GC.GetTotalMemory(true)} byte.");


GC.Collect();
GC.WaitForPendingFinalizers();
Console.WriteLine($"Collect işlemi sonrası: {GC.GetTotalMemory(true)} byte.");

using FileProcess fp = new FileProcess ();
var array = Encoding.UTF8.GetBytes("Bu bir cümledir");
Console.WriteLine($"array işlemi sonrası: {GC.GetTotalMemory(true)} byte.");
fp.WriteToFile(array);
fp.Zipped("zipped.zip");
Console.WriteLine($"Zip işlemi sonrası: {GC.GetTotalMemory(true)} byte.");

Console.WriteLine("-------------------------------------------------------");
GC.Collect();
GC.WaitForPendingFinalizers();
Console.WriteLine($"Collect işlemi sonrası: {GC.GetTotalMemory(true)} byte.");