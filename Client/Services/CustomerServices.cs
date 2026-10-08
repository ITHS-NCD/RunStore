using System;
using System.Collections.Generic;
using Client.Models;
using Client.ViewModels;

namespace Client;

public class CustomerServices
{
    public static List<Customer> ListAllCustomers()
    {
        return [
            new Customer{FirstName = "Alfred", LastName = "Wendt", Email = "affewendt@gmail.com", PhoneNumber = "0760869095", Street="Mölndalsvägen 69A", ZipCode="41285", City="Göteborg"},
            new Customer{FirstName = "Göran", LastName = "Larsson", Email = "göran.larsson@hotmail.com", PhoneNumber= "+46708479889"},
        ];
    }
}
