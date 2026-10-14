using System;
using Avalonia.Controls;

namespace Client.ViewModels;

public class OrdersViewModel : PageViewModel
{
  public OrdersViewModel()
  {
    PageName = Helpers.ApplicationNameEnum.Orders;
  }
}
