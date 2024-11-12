// See https://aka.ms/new-console-template for more information
int bolme(int bolunen, int bolen)
{
    return bolunen / bolen;
}
int bolme2(int bolunen, int bolen, out int kalan)
{
    kalan = bolunen % bolen;
    return bolunen / bolen;
}

BolmeSonucu bolme3(int bolunen, int bolen)
{
    return new BolmeSonucu { Sonuc = bolunen/bolen, Kalan = bolunen % bolen };  
}

Tuple<int, int> bolme4(int a, int b) => Tuple.Create(a / b, a % b);

(int sonuc, int kalan) bolme5(int a, int b)
{
    return (a / b, a % b);
}



int output = 0;
int result = bolme2(15, 4, out output);
var result2 = bolme3(15, 4);
(int sonuc, int kalan) = bolme4(15, 4);
Console.WriteLine($"deconstruction ile tuple {sonuc}, {kalan}");
(int sonuc2, int kalan2) = bolme5(20, 3);
Console.WriteLine($"deconstruction ile tuple {sonuc2}, {kalan2}");

//Burada bir grup bağımsız (bir araya gelemeyen) değişkenleri tanımlamak için bu syntax'ı kullandık.
//Yoksa elbette bir sınıfın yerini asla tutmaz.
(string name, string lastName, int age) = ("Türkay", "Ürkmez", 44);







class BolmeSonucu
{
    public int Sonuc { get; set; }
    public int Kalan { get; set; }
}