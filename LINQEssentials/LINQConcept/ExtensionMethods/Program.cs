// See https://aka.ms/new-console-template for more information
using ExtensionMethods;

Console.WriteLine("Hello, World!");

int x = 5;
Console.WriteLine(x.GetSquare());
Random random = new Random();
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(random.NextChar(false));
}

Console.WriteLine(random.NextString(5));
var dates = new List<DateTime>()
{
    new(2024,5,19),
    new(2024,10,29),
    new(2024,4,23)
};
Console.WriteLine(  $"toplam çalışma günü {new DateTime(2025,1,1).TotalWorkDays(dates.ToArray())}");