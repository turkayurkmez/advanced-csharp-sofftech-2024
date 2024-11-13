// See https://aka.ms/new-console-template for more information
using dynamicKeyword;

dynamic value = "Dinamik";
/*
   function test(value){
      value.name = 'info';
   }
 */
//dynamic keyword'ü söz konusu yapının (değişken, dönüş değeri parametre veya özellik) uygulama çalışırken denetleneceğini söyler.
Console.WriteLine(value.ToLower());

void showName(dynamic parameter)
{
    Console.WriteLine(parameter.Name);
}


Product product = new Product() { Name="Ürün Adı"};
Vendor vendor = new Vendor() { Name = "Marka Adı" };
Customer customer = new Customer() { Name = "Müşteri Adı" };

showName(product);
showName(vendor);
showName(customer);

var process = new {Name="veritabanına eklendi", ElapsedTime= TimeSpan.FromSeconds(10)};

logProcess(process);

void logProcess(dynamic process)
{
    Console.WriteLine($"İşlem adı:{process.Name}, {process.ElapsedTime} saniyede tamamlandı");
}

dynamic getSomeInfo()
{
    return new { Name = "Türkay", Role = "Admin", Age = 44 };
}

Console.WriteLine($"{getSomeInfo().Name} {getSomeInfo().Role}");



