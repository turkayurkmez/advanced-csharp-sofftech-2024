// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
long totalSize = 0;
string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
var files = Directory.GetFiles(directoryPath);
Console.WriteLine("------ Klasör taranıyor -----");
Parallel.For(0, files.Length, index =>
{
    FileInfo fileInfo = new FileInfo(files[index]);
    var size = fileInfo.Length;
    Console.WriteLine($"{fileInfo.Name} - {size} byte");
   Interlocked.Add(ref totalSize, size);
});


Console.WriteLine($"Klasörün toplam büyüklüğü: {totalSize} byte");