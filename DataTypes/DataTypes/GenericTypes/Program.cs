using GenericTypes;
using System.Collections;
using System.Data;

void showSomething(object o)
{
    Console.WriteLine(o);
}


object o = 5;
object o2 = new Random();
object o3 = "Naber?";
object o4 = new DataTable();


int value = (int)o;
//string strValue  = (string)o;
showSomething(new List<string> { "a","B","C" });
ArrayList list = new ArrayList();
list.Add("üç");
list.Add(true);
list.Add(0.15);
list.Add(new Random());

var firstItem = (string)list[0];

PointObject pointObject = new PointObject();
pointObject.X = "test";
pointObject.Y = 8;

PointGeneric<decimal> pointGeneric = new PointGeneric<decimal>();
pointGeneric.X = 13.6m;
pointGeneric.Y = 0.2m;

PointGeneric<double> pointRandom = new PointGeneric<double>();


Gitar[] gitarlar = new Gitar[2];
gitarlar[0] = new ElektroGitar();

Gitar[] elektroGitarlar = new ElektroGitar[2];
//elektroGitarlar[0] = new Gitar();

List<ElektroGitar> elektroGitars = new List<ElektroGitar>();
//elektroGitars.Add(new Gitar());


Simple simple = new Simple();
simple.Process(new ElektroGitar());
simple.Process(new Gitar());

