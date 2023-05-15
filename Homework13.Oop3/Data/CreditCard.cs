using Homework13.Oop3.Interfaces;

namespace Homework13.Oop3.Data;

public class CreditCard<TMoney>: ICard<TMoney> where TMoney: struct
{
    public string Name { get; set; }
    public TMoney Money { get; set; }

    public CreditCard(string name, TMoney money)
    {
        Name = name;
        Money = money;
    }

    public override string ToString()
    {
        return Name;
    }

}
