// See https://aka.ms/new-console-template for more information
using SerializtionSample;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

Console.WriteLine("Hello, World!");
ProductList productList = new ProductList();
productList.Add(new() { Id = 1, Price = 100, Description = "Ürün 1 Açıklama", Name = new NameDetail { English = "Laptop", Turkish = "Dizüstü" } });
productList.Add(new() { Id = 2, Price = 200, Description = "Ürün 2 Açıklama", Name = new NameDetail { English = "Shirt", Turkish = "Gömlek" } });
productList.Add(new() { Id = 3, Price = 500, Description = "Ürün 3 Açıklama", Name = new NameDetail { English = "Sunglasses", Turkish = "Güneş gözlüğü" } });

string path = "../../../products.xml";
serializeToXML(path, productList);
//ProductList productListFromXML = deserializeFromXML(path);

string jsonPath = "../../../products.json";
var jsonSerialize=  serializeToJson(jsonPath, productList);
ProductList productListFromJson = deserializeFromJson(jsonPath);

Console.ReadLine();
serializeToBinary("../../../products.txt", jsonSerialize);



void serializeToXML(string path, ProductList productList)
{
    Console.WriteLine(" ---- XML formatında serileştiriliyor ------- ");
    XmlSerializer xmlSerializer = new XmlSerializer(typeof(ProductList));
    using FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate);
    xmlSerializer.Serialize(fileStream, productList);


}

ProductList deserializeFromXML(string path)
{
    XmlSerializer serializer = new XmlSerializer(typeof(ProductList));
    var list = (ProductList)serializer.Deserialize(new FileStream(path, FileMode.Open));
    return list;
}

string serializeToJson(string path, ProductList productList)
{
    var jsonResult = JsonSerializer.Serialize(productList);
    File.WriteAllText(path, jsonResult);

    return jsonResult;
}

ProductList? deserializeFromJson(string jsonPath)
{
    var json = File.ReadAllText(jsonPath);
    return JsonSerializer.Deserialize<ProductList>(json);

}

//serializeToBinary("../../../binary.txt", productList);

void serializeToBinary(string path, string json)
{
    var binarySerialize = Encoding.ASCII.GetBytes(json);
    FileStream fileStream = new FileStream (path, FileMode.CreateNew);
    fileStream.Write(binarySerialize, 0, binarySerialize.Length);
    fileStream.Close();

}