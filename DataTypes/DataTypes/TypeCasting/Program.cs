// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
byte x = 255;
byte y = 1;

checked
{
    byte total = (byte)(x + y);
    Console.WriteLine(total);
}

