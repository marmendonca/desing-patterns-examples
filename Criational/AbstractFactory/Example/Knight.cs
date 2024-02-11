using DesingPatternsExamples.Criational.AbstractFactory.Example.Interfaces;

namespace DesingPatternsExamples.Criational.AbstractFactory.Example;

// Personagem concreto: Cavaleiro
public class Knight : ICharacter
{
    public void Attack()
    {
        Console.WriteLine("Cavaleiro ataca com espada!");
    }
}