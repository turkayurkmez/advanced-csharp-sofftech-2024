// See https://aka.ms/new-console-template for more information

using AnonymousType;

IEnumerable<string> getStrings()
{
    return new List<string> { "A", "B", "C" };
}
Console.WriteLine("Hello, World!");

var anonym = new { Name = "Türkay", IsOnline = true };
var letters = getStrings();

var products = new ProductService().GetProducts();
var query = from product in products
            where product.Price > 10
            orderby product.Name
            select new SpecialProductInfo { UrunAdi = product.Name, Renk = product.Color };

//   select * from products
foreach (var item in query)
{
    Console.WriteLine($"{item.UrunAdi}, {item.Renk}");
}
//ya LINQ olmasaydı?
List<SpecialProductInfo> list = new List<SpecialProductInfo>();
foreach (var item in products)
{
    if (item.Price > 10)
    {
        list.Add(new SpecialProductInfo { Renk = item.Color, UrunAdi = item.Name });
    }

}
//Extension metod ile LINQ:
var queryWithExtension = products.Where(p => p.Price > 10)
                                 .OrderBy(p=>p.Name)
                                 .ToList();
int x = 5;

