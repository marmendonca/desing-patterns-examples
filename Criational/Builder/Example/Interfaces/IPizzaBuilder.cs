namespace DesingPatternsExamples.Criational.Builder.Example.Interfaces;

public interface IPizzaBuilder
{
    void SetSize(string size);
    void SetDough(string dough);
    void SetSauce(string sauce);
    void SetCheese(string cheese);
    void SetToppings(string toppings);
    Pizza GetPizza();
}