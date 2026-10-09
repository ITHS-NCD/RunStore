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
    static Storage<Product> storage = new();

    public static List<Product> ListAllProducts()
    {
        var json = storage.Read(_path).OrderBy(x => x.ItemNumber).ToList();
        return json;
    }
}
