using DesingPatternsExamples.Criational.Builder.Example.Interfaces;

namespace DesingPatternsExamples.Criational.Builder.Example;

public class PizzaBuilder : IPizzaBuilder
{
    private Pizza _pizza = new Pizza();

    public void SetSize(string size)
    {
        _pizza.Size = size;
    }

    public void SetDough(string dough)
    {
        _pizza.Dough = dough;
    }

    public void SetSauce(string sauce)
    {
        _pizza.Sauce = sauce;
    }

    public void SetCheese(string cheese)
    {
        _pizza.Cheese = cheese;
    }

    public void SetToppings(string toppings)
    {
        _pizza.Toppings = toppings;
    }

    public Pizza GetPizza()
    {
        return _pizza;
    }
}