using Homework13.Oop3.Interfaces;
using System;

namespace Homework13.Oop3.Data;

public class CreditCard<TMoney>: ICard<TMoney> where TMoney: struct
{
    public string Name { get; set; }

    public CardKind CardKind { get; set; } = CardKind.Credit;

    public TMoney Limit { get; set; }
    public TMoney Money { get; private set; }

    public CreditCard(string name, TMoney limit)
    {
        Name = name;
        Limit = limit;
    }

    public override string ToString()
    {
        return Name;
    }

    public void ChangeMoney(TMoney money)
    {
        var newMoney = (dynamic)Money + money;
        if (newMoney < -(dynamic)Limit)
        {
            throw new Exception("Сумма кредитного счета не может быть меньше лимита");
        }
        else
        {
            Money = newMoney;
        }
    }
}
