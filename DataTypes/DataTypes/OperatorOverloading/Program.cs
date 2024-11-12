// See https://aka.ms/new-console-template for more information
using OperatorOverloading;

Console.WriteLine("Hello, World!");


var stringTest = "a" + "b";
var intTest = 3 + 5;
var strTest2 = "a" + 3;

List<CardItem> cardItems = new List<CardItem>();
CardItem c1 = new CardItem() { ProductId=1, Name = "Ürün A", Price = 10, Quantity = 3 };
CardItem c2 = new CardItem() { ProductId=3, Name = "Ürün A", Price = 30, Quantity = 5 };

cardItems.Add(c1);
cardItems.Add(c2);

//var c3 = c1 + c2;
//Console.WriteLine($"Manuel toplama {c3}");


decimal result = 0;
foreach (var cardItem in cardItems)
{
    result += cardItem;
}
Console.WriteLine($"Sepet toplamı:{result}");

decimal result2 = 0;
foreach (var cardItem in cardItems)
{
    result2 += cardItem.Quantity * cardItem.Price;
}

