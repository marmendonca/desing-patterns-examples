using DesingPatternsExamples.Criational.AbstractFactory.Example.Interfaces;

namespace DesingPatternsExamples.Criational.AbstractFactory.Example;

// Fábrica concreta para criar objetos de personagens e armas medievais
public class MedievalFactory : ICharacterFactory
{
    public ICharacter CreateCharacter()
    {
        return new Knight();
    }
    
    public IWeapon CreateWeapon()
    {
        return new Sword();
    }
}