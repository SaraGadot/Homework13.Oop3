namespace Homework13.Oop3.Interfaces;

public interface ICard<TMoney> where TMoney : struct
{
    string Name { get; set; }
    TMoney Money { get; set; }
}
