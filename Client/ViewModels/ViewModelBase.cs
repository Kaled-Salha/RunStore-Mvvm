using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Client.ViewModels;

public partial class ViewModelBase : ObservableObject
{
  [ObservableProperty] //its a signal to xaml file to update the property
  public partial string PageTitle { get; set; } = "";

}
