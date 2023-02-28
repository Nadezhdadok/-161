using System.IO;
using System.Text.Json;
using Задача_161;

string jsonString = String.Empty;
using (StreamReader sr = new StreamReader("Products.json"))
{
    jsonString = sr.ReadToEnd();
}
Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);
Product maxProduct = products[0];
foreach (Product e in products)
{
    if (e.Summa > maxProduct.Summa)
    {
        maxProduct = e;
    }
}
Console.WriteLine($"{maxProduct.Code} {maxProduct.Name} {maxProduct.Summa}");
