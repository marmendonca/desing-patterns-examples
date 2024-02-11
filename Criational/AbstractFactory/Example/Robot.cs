using DesingPatternsExamples.Criational.AbstractFactory.Example.Interfaces;

namespace DesingPatternsExamples.Criational.AbstractFactory.Example;

// Personagem concreto: Robô
public class Robot : ICharacter
{
    public void Attack()
    {
        Console.WriteLine("Robô ataca com laser!");
    }
}