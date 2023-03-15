namespace Homework13.Oop3.Data;

public class Card<TMoney> where TMoney: struct
{
    public string Name { get; set; }
    public TMoney Money { get; set; }

    public Card (string name, TMoney money = default)
    {
        Name = name;
        Money = money;

    }

    public override string ToString()
    {
        return Name;
    }
}
