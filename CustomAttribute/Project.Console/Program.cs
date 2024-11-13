// See https://aka.ms/new-console-template for more information
using Project.Core;
using System.Reflection;

var file = @"C:\Users\turka\source\repos\Kurumsal\Softtech\2024\İleri C#\CustomAttribute\Project.Entities\bin\Debug\net8.0\Project.Entities.dll";
var assembly = Assembly.LoadFile(file);
foreach (var type in assembly.GetTypes())
{
    developerInfoConsole(type);
}

void developerInfoConsole(Type type)
{
    Console.WriteLine("Yazılımcı tarafından girilen bilgiler okunuyor....");
    Console.WriteLine("-------------------------------");
    Attribute[] attributes = Attribute.GetCustomAttributes(type);

    foreach (Attribute attribute in attributes)
    {
        if (attribute is DeveloperInfoAttribute developerInfo)
        {
            Console.WriteLine($"Sınıf adı: {type.Name} ");
            Console.WriteLine($"Yazılımcı adı: {developerInfo.Name}");
            Console.WriteLine($"Kodun açıklaması: {developerInfo.CodeDescription}");
            Console.WriteLine($"Kodun açıklaması: {developerInfo.CreatedDate}");
            Console.WriteLine("********************************");

            var members = type.GetMembers();
            showMemberInfo( members );
        }
    }
}

void showMemberInfo(MemberInfo[] members)
{
    foreach (var member in members)
    {
        foreach (var attribute in member.GetCustomAttributes())
        {
            if (attribute is DeveloperInfoAttribute developer)
            {
                Console.WriteLine($"Üye adı:{member.Name}");
                Console.WriteLine($"Üye tipi:{member.MemberType}");
                Console.WriteLine($"Yazılmcı adı: {developer.Name}");
                Console.WriteLine($"Yazılmcı açıklaması: {developer.CodeDescription}");


            }
        }
    }
}