using Homework13.Oop3.Interfaces;

namespace Homework13.Oop3.Data;

public class DepositCard<TMoney>: ICard<TMoney> where TMoney: struct
{
    public string Name { get; set; }

    public CardKind CardKind { get; set; } = CardKind.Deposit;
    public TMoney Money { get; set; }

    public DepositCard (string name, TMoney money = default)
    {
        Name = name;
        Money = money;

    }

    public override string ToString()
    {
        return Name;
    }
}
