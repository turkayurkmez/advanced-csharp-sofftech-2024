// See https://aka.ms/new-console-template for more information
using RecordTypes;

Console.WriteLine("Hello, World!");

Product product1 = new Product(1, "Laptop", 80000);
Product product2 = new Product(1, "Laptop", 80000);

Console.WriteLine($"product1 == product2 karşılaştırma sonucu: {product1 == product2} ");
Console.WriteLine($"product1.Equals(product2) karşılaştırma sonucu: {product1.Equals(product2)}");
Console.WriteLine($"product1.GetHashCode() == product2.GetHashCode()  karşılaştırma sonucu: {product1.GetHashCode() == product2.GetHashCode()}");

//kaynak 1:
Address address = new Address("Eskişehir", "Sümer", "Türkiye");

//kaynak 2:
Person person = new Person { Id = 1, Name = "Ertuğrul", Addresses = new List<Address>() };
person.Addresses.Add(new Address("Yalova","Efsane Fırın","Türkiye"));
person.Addresses.Add(new Address("Eskişehir", "Sümer", "Türkiye"));

var isFind = person.Addresses.Any(x=>x == address);
Console.WriteLine($"Person nesnesinin adresleri içinde aranan adres var mı? {isFind}");

