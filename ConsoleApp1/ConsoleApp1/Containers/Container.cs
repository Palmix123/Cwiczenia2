using ConsoleApp1.Interfaces;

namespace ConsoleApp1;

public abstract class Container : IContainer
{
    public double CargoWeight { get; set; }
    protected Container(double cargoWeight)
    {
        CargoWeight = cargoWeight;
    }


    public virtual void Unload()
    {
        if (CargoWeight > 100)
        {
            throw new OverflowException();
        }
        throw new NotImplementedException();
    }

    public virtual void Load(double cargoWeight)
    {
        throw new NotImplementedException();
    }
}