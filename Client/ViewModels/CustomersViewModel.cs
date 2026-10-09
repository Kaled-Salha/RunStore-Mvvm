using System;
using System.Collections.ObjectModel;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Client.ViewModels;

public partial class CustomersViewModel : ViewModelBase
{

  [ObservableProperty]
  public partial ObservableCollection<Customer> Customers { get; set; } = [];
  public CustomersViewModel()
  {
    PageTitle = "Våra Kunder";
    LoadCustomers();
  }

  private void LoadCustomers()
  {
    // var customers = CustomerServices.ListAllCustomers();
    // Customers = new ObservableCollection<Customer>(customers);

    Customers = new ObservableCollection<Customer>(CustomerServices.ListAllCustomers()); //One Liner

  }


}
