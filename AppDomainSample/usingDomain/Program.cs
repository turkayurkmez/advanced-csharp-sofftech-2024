// See https://aka.ms/new-console-template for more information
Console.WriteLine("App Domain Bilgileri");
AppDomain domain = AppDomain.CurrentDomain;
Console.WriteLine($"İsim: {domain.FriendlyName}");
Console.WriteLine($"Ana klasör: {domain.BaseDirectory}");
Console.WriteLine($"Uygulama klasörü: {domain.SetupInformation.ApplicationBase}");
Console.WriteLine($"Framework: {domain.SetupInformation.TargetFrameworkName}");
Console.WriteLine($"Ekli referans sayısı: {domain.GetAssemblies().Length}");
Console.WriteLine($"Ekli referanslar: {domain.GetAssemblies().Select(a=>a.FullName).Aggregate((a,b)=> a+"\n"+b)}");



