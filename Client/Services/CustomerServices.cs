using System;
using System.Collections.Generic;
using Client.Models;

namespace Client.Services;

public class CustomerServices
{
  public static List<Customer> ListAllCustomers()
  {
    return [
      new Customer{firstName = "Gel", lastName = "Asics",Adress = "Hisingen123", Email = "GelAsics@gmail.com"},
      new Customer{firstName = "Sneakers", lastName = "Kaaa",Adress="Angered111", Email = "SneakersKaa@gmail.com"}
    ];
  }

}
