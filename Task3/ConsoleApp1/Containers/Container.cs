using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Containers;

public abstract class Container : IContainer
{
    private double _cargoMass;
    protected Container(double cargoMass)
    { 
        CargoMass = cargoMass;
    }

    public double CargoMass { get;protected set; }

    public void Unload()
    {
        _cargoMass = 0;
    }

    public void Load(double cargoMass)
    {
        _cargoMass += cargoMass;
    }
    
}