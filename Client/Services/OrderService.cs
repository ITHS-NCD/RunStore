using System;
using System.Collections.Generic;
using System.IO;
using Client.Models;
using Client.Repositories;

namespace Client.Services;

public class OrderServices
{
    private readonly static string _path = string.Concat(Environment.CurrentDirectory, "/Data/orders.json");
    private static Storage<Order> storage = new();

    public static List<Order> ListAllOrders()
    {
        if (!Directory.Exists(Environment.CurrentDirectory + "/Data"))
        {
            Directory.CreateDirectory(Environment.CurrentDirectory + "/Data");
        }
        if (!File.Exists(_path))
        {
            File.Create(_path);
        }

        var order = storage.Read(_path);
        return order;
    }
}
