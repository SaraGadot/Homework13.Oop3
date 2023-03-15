using Homework13.Oop3.Data;
using System.Collections.Generic;

namespace Homework13.Oop3;

public class Client
{
   
    public string Name { get; set; }
    public List<Card<decimal>> Cards { get; set; } = new List<Card<decimal>>();

    public Client (string name, List<Card<decimal>> cards)
    {
        Name = name;
        Cards = cards;

    }

    public override string ToString()
    {
        return Name;
    }
}
