using Homework13.Oop3.Data;

namespace Homework13.Oop3;
internal class CardManager
{
    public static DepositCard<decimal> OpenCard(Client client, string cardName, decimal money)
    {
        var card = new DepositCard<decimal>(cardName, money);
        client?.Cards.Add(card);
        return card;
    }

    public static void CloseCard(Client? client, DepositCard<decimal> card)
    {
        client?.Cards.Remove(card);

    }


    public static void Transfer<TMoney>(DepositCard<TMoney> fromCard, DepositCard<TMoney> toCard, TMoney money) where TMoney:struct
    {
        fromCard.Money = Minus(fromCard.Money, money);
        toCard.Money = Plus(toCard.Money, money);
    }

    private static TNumber Minus<TNumber>(TNumber a, TNumber b)
    {
        return (dynamic)a - b;
    }
    private static TNumber Plus<TNumber>(TNumber a, TNumber b)
    {
        return (dynamic)a + b;
    } 


}

