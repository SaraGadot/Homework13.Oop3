using Homework13.Oop3.Data;
using System.Collections.Generic;

namespace Homework13.Oop3;

public class Client
{
   
    public string Name { get; set; }
    public List<Card> Cards { get; set; } = new List<Card>();

    public Client (string name, List<Card> cards)
    {
        Name = name;
        Cards = cards;

    }

}
