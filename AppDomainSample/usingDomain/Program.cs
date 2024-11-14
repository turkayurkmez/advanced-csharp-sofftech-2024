// See https://aka.ms/new-console-template for more information
using System.Runtime.Loader;
using usingDomain;

Console.WriteLine("App Domain Bilgileri");
AppDomain domain = AppDomain.CurrentDomain;
Console.WriteLine($"İsim: {domain.FriendlyName}");
Console.WriteLine($"Ana klasör: {domain.BaseDirectory}");
Console.WriteLine($"Uygulama klasörü: {domain.SetupInformation.ApplicationBase}");
Console.WriteLine($"Framework: {domain.SetupInformation.TargetFrameworkName}");
Console.WriteLine($"Ekli referans sayısı: {domain.GetAssemblies().Length}");
Console.WriteLine($"Ekli referanslar: {domain.GetAssemblies().Select(a=>a.FullName).Aggregate((a,b)=> a+"\n"+b)}");

Console.WriteLine(".....................................");
Console.WriteLine("Başka bir domain yükleniyor..........");

AssemblyLoadContext calculatorDomain = new AssemblyLoadContext(name: "CalculatorDomain", true);
try
{
	Type type = typeof(Calculator);
	var calculator =  (ICalculator)Activator.CreateInstance(type);
	int sonuc = calculator.Add(3, 5);
    calculatorDomain.Assemblies.ToList().ForEach(x=>Console.WriteLine(x.FullName));

}
catch (Exception)
{

	throw;
}
