namespace DesingPatternsExamples.Criational.Builder.Example;

public class Pizza
{
    public string Size { get; set; }
    public string Dough { get; set; }
    public string Sauce { get; set; }
    public string Cheese { get; set; }
    public string Toppings { get; set; }

    public override string ToString()
    {
        return $"Pizza: {Size}, {Dough}, {Sauce}, {Cheese}, {Toppings}";
    }
}
