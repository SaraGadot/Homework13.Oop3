namespace Homework13.Oop3.Data;

public class Card
{
    public string Name { get; set; }
    public decimal Money { get; set; }

    public Card (string name, decimal money = 0)
    {
        Name = name;
        Money = money;

    }

}
