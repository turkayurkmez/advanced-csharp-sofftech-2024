// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");
var maxNumber = 20000000;
var numbers = Enumerable.Range(1, maxNumber).ToList();
var stopWatch = Stopwatch.StartNew();
var evenNumbersNormal = getEvenNumbersNormal(numbers);
stopWatch.Stop();

var parallelStopWatch = Stopwatch.StartNew();
var evenNumbersParallel = getEvenNumbersParallel(numbers);
parallelStopWatch.Stop();

Console.WriteLine($"Normal foreach:{stopWatch.ElapsedMilliseconds}\nParallel Foreach: {parallelStopWatch.ElapsedMilliseconds}");

List<int> getEvenNumbersParallel(List<int> numbers)
{
    var output = new List<int>(10000000);
    Parallel.ForEach(numbers, n =>
    {
        if (n % 2 == 0)
        {
            output.Add(n);
        }
    });

    return output;
}

List<int> getEvenNumbersNormal(List<int> numbers)
{
    var output = new List<int>(10000000);
    foreach (var number in numbers)
    {
        if (number % 2 == 0)
        {
            output.Add(number);
        }
    }
    return output;

}