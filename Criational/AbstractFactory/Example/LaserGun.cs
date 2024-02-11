using DesingPatternsExamples.Criational.AbstractFactory.Example.Interfaces;

namespace DesingPatternsExamples.Criational.AbstractFactory.Example;

// Arma concreta: Arma de Laser
public class LaserGun : IWeapon
{
    public void UseWeapon()
    {
        Console.WriteLine("Usando arma de laser!");
    }
}