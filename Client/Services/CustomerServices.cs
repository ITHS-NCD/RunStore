using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Avalonia.Metadata;
using Client.Models;
using Client.Repositories;
using Client.ViewModels;

namespace Client;

public class CustomerServices
{
    private readonly static string _path = string.Concat(Environment.CurrentDirectory, "/Data/customers.json");
    private static Storage<Customer> storage = new();
    public static List<Customer> ListAllCustomers()
    {
        if (!Directory.Exists(Environment.CurrentDirectory + "/Data"))
        {
            Directory.CreateDirectory(Environment.CurrentDirectory + "/Data");
        }
        if (!File.Exists(_path))
        {
            File.Create(_path);
        }
        var customer = storage.Read(_path).OrderBy(x => x.LastName).ToList();
        return customer;
    }
}
