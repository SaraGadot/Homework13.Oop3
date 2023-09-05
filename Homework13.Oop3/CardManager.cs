using Homework13.Oop3.Data;
using Homework13.Oop3.Interfaces;

namespace Homework13.Oop3;
internal class CardManager
{
    public static ICard<decimal> OpenCard(Client client, string cardName, decimal money)
    {
        var card = new CreditCard<decimal>(cardName, money);
        client?.Cards.Add(card);
        return card;
    }

    public static void CloseCard(Client? client, ICard<decimal> card)
    {
        client?.Cards.Remove(card);

    }


    public static void Transfer<TMoney>(ICard<TMoney> fromCard,ICard<TMoney> toCard, TMoney money) where TMoney:struct
    {
        fromCard.ChangeMoney(-(dynamic)money);
        toCard.ChangeMoney(money);
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

