using DesingPatternsExamples.Criational.AbstractFactory.Example.Interfaces;

namespace DesingPatternsExamples.Criational.AbstractFactory.Example;

// Fábrica concreta para criar objetos de personagens e armas futuristas
public class FuturisticFactory : ICharacterFactory
{
    public ICharacter CreateCharacter()
    {
        return new Robot();
    }

    public IWeapon CreateWeapon()
    {
        return new LaserGun();
    }
}