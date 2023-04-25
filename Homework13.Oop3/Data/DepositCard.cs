namespace Homework13.Oop3.Data;

public class DepositCard<TMoney> where TMoney: struct
{
    public string Name { get; set; }
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
