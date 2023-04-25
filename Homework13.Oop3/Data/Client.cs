using Homework13.Oop3.Data;
using System.Collections.Generic;

namespace Homework13.Oop3;

public class Client
{
   
    public string Name { get; set; }
    public List<DepositCard<decimal>> Cards { get; set; } = new List<DepositCard<decimal>>();

    public Client (string name, List<DepositCard<decimal>> cards)
    {
        Name = name;
        Cards = cards;

    }

    public override string ToString()
    {
        return Name;
    }
}
