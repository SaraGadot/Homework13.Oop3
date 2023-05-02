using Homework13.Oop3.Data;
using Homework13.Oop3.Interfaces;
using System.Collections.Generic;

namespace Homework13.Oop3;

public class Client
{
   
    public string Name { get; set; }
    public List<ICard<decimal>> Cards { get; set; } = new List<ICard<decimal>>();

    public Client (string name, List<ICard<decimal>> cards)
    {
        Name = name;
        Cards = cards;

    }

    public override string ToString()
    {
        return Name;
    }
}
