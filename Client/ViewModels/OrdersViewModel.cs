using System;
using System.Collections.ObjectModel;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Client.ViewModels;

public partial class OrdersViewModel : ViewModelBase
{
    [ObservableProperty]
    public partial ObservableCollection<Order> Orders { get; set; } = [];
    public OrdersViewModel()
    {
        PageTitle = "Beställningar";
        LoadOrders();
    }

    private void LoadOrders()
    {
        try
        {
            Orders = new ObservableCollection<Order>(OrderServices.ListAllOrders());
        }
        catch (System.Exception)
        {

            throw;
        }
    }
}
