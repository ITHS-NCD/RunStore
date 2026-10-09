using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Avalonia.Controls.Platform;
using Client.Models;
using Client.Repositories;

namespace Client.Services;

public class ProductServices
{
    private static string _path = Directory.GetCurrentDirectory() + "/Data/products.json";
    private static Storage<Product> storage = new();

    public static List<Product> ListAllProducts()
    {
        if (!Directory.Exists(Environment.CurrentDirectory + "/Data"))
        {
            Directory.CreateDirectory(Environment.CurrentDirectory + "/Data");
        }
        if (!File.Exists(_path))
        {
            File.Create(_path);
        }
        var products = storage.Read(_path).OrderBy(x => x.ItemNumber).ToList();
        return products;
    }
}
