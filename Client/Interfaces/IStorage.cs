using System;
using System.Collections.Generic;

namespace Client.Interfaces;

public interface IStorage<T> where T : class
{
  List<T> Read(string path);
  //Vad ska vi skriva, Vart vi skriver det
  void Write(string path, List<T> data);

}
