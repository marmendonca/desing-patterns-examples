using DesingPatternsExamples.Criational.AbstractFactory.Example.Interfaces;

namespace DesingPatternsExamples.Criational.AbstractFactory.Example;

// Interface abstrata para a fábrica de personagens
public interface ICharacterFactory
{
    ICharacter CreateCharacter();
    IWeapon CreateWeapon();
}