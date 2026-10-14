using System;
using System.Collections.ObjectModel;
using Client.Interfaces;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Client.ViewModels;

public partial class CustomersViewModel : PageViewModel
{
  private ICustomerService _customerService;

  [ObservableProperty]
  public partial ObservableCollection<Customer> Customers { get; set; } = [];
  public CustomersViewModel()
  {
    PageTitle = "Våra Kunder";
    // LoadCustomers();
  }
  public CustomersViewModel(ICustomerService customerService)
  {

    _customerService = customerService;
    PageName = Helpers.ApplicationNameEnum.Customers;
    PageTitle = "Våra Kunder";

    LoadCustomers();
  }

  private void LoadCustomers()
  {
    // var customers = CustomerServices.ListAllCustomers();
    // Customers = new ObservableCollection<Customer>(customers);

    Customers = new ObservableCollection<Customer>(_customerService.List()); //One Liner

  }


}
