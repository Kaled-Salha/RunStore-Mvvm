using System;
using System.Collections.ObjectModel;
using Client.Interfaces;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Client.ViewModels;

public partial class CustomersViewModel : ViewModelBase
{
  private ICustomerService _service;

  [ObservableProperty]
  public partial ObservableCollection<Customer> Customers { get; set; } = [];
  public CustomersViewModel(ICustomerService service)
  {
    PageTitle = "Våra Kunder";
    _service = service;
    LoadCustomers();
  }

  private void LoadCustomers()
  {
    // var customers = CustomerServices.ListAllCustomers();
    // Customers = new ObservableCollection<Customer>(customers);

    Customers = new ObservableCollection<Customer>(_service.List()); //One Liner

  }


}
