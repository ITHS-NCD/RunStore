using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Client.ViewModels;

public class AddViewModel : ViewModelBase
{
    public AddViewModel()
    {
        PageTitle = "Lägg till produkter, kunder eller beställningar";
    }
}