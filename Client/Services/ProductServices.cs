using System;
using System.Collections.Generic;
using Client.Models;

namespace Client.Services;

public class ProductServices
{
    public static List<Product> ListAllProducts()
    {
        return [
            new Product{ItemNumber = "1001", Name = "Gel 27", SupplierName = "Asics", Price=2295},
            new Product{ItemNumber = "1002", Name = "Superblast 3", SupplierName = "Asics", Price=1999},
            new Product{ItemNumber = "1003", Name = "Superblast 1", SupplierName = "Asics", Price=1295},
        ];
    }
}
