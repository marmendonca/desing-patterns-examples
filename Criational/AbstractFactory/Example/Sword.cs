using DesingPatternsExamples.Criational.AbstractFactory.Example.Interfaces;

namespace DesingPatternsExamples.Criational.AbstractFactory.Example;

// Arma concreta: Espada
public class Sword : IWeapon
{
    public void UseWeapon()
    {
        Console.WriteLine("Usando espada!");
    }
}