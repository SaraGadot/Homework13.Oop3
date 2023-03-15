using Homework13.Oop3.Data;

namespace Homework13.Oop3;
internal class CardManager
{
    public static void Transfer<TMoney>(Card<TMoney> fromCard, Card<TMoney> toCard, TMoney money) where TMoney:struct
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

