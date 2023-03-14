using Homework13.Oop3.Data;

namespace Homework13.Oop3;
internal class CardManager
{
    public static void Transfer(Card fromCard, Card toCard, decimal money)
    {
        fromCard.Money = fromCard.Money - money;
        toCard.Money = toCard.Money + money;
    }
}

