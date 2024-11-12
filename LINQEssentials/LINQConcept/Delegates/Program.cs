// See https://aka.ms/new-console-template for more information
using Delegates;
using System.Threading.Channels;

bool isEven(int number)
{
    return number % 2 == 0;
}

//int[] filter(int[] array)
//{
//    List<int> filtered = new List<int>();
//    foreach (var number in array)
//    {
//        if (isEven(number))
//        {
//            filtered.Add(number);
//        }

//    }
//    return filtered.ToArray();
//}

void showItems(int[] array)
{
    Console.WriteLine(string.Join(',', array));
}

void showWithAction(int[] array)
{
    array.ToList().ForEach(n => Console.WriteLine(n));
}


var items = new int[] { 3, 19, -9, 16, 25, 94 };
NumberFilter numberFilter = new NumberFilter();

//.net 1.1:
var filteredResult = numberFilter.Filter(items, isEven);
showItems(filteredResult);
//.net 2.0:
var oddNumbers = numberFilter.Filter(items,
    delegate (int x)
    {
        return x % 2 != 0;
    }
);
Console.WriteLine();
showItems(oddNumbers);
//.net 3.5:
var negativeNumbers = numberFilter.Filter(items, p => p < 0);
showItems(negativeNumbers);




