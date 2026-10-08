using System;
using System.Collections.Generic;
using Client.ViewModels;

namespace Client;

public class CustomerServices
{
    public static List<Customer> ListAllCustomers()
    {
        return [
            new Customer{FirstName = "Alfred", LastName = "Wendt", Email = "affewendt@gmail.com", PhoneNumber = "0760869095"},
            new Customer{FirstName = "Göran", LastName = "Larsson", Email = "göran.larsson@hotmail.com", PhoneNumber= "+46708479889"},
        ];
    }
}
