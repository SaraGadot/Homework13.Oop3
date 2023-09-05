using Homework13.Oop3.Interfaces;
using System;

namespace Homework13.Oop3.Data;

public class DepositCard<TMoney>: ICard<TMoney> where TMoney: struct
{
    public string Name { get; set; }

    public CardKind CardKind { get; set; } = CardKind.Deposit;
    public TMoney Money { get; private set; }

    public DepositCard (string name, TMoney money = default)
    {
        Name = name;
        Money = money;

    }

    public override string ToString()
    {
        return Name;
    }

    public void ChangeMoney(TMoney money)
    {
        var newMoney = (dynamic)Money + money;
        if ((dynamic)newMoney < 0)
        {
            throw new Exception("Сумма депозитного счета не может быть меньше нуля");
        }
        else
        {
            Money = newMoney;
        }
    }
}
