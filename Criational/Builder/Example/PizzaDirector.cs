using DesingPatternsExamples.Criational.Builder.Example.Interfaces;

namespace DesingPatternsExamples.Criational.Builder.Example;

public class PizzaDirector
{
    private readonly IPizzaBuilder _builder;

    public PizzaDirector(IPizzaBuilder builder)
    {
        _builder = builder;
    }

    public void MakePizza()
    {
        _builder.SetSize("Large");
        _builder.SetDough("Thin Crust");
        _builder.SetSauce("Tomato");
        _builder.SetCheese("Mozzarella");
        _builder.SetToppings("Pepperoni, Mushrooms, Onions");
    }
}