using ConsoleApp1.Exceptions;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Containers;

public abstract class Container : IContainer
{
    protected double _cargoWeight { get; set; }
    protected double _height { get; }
    protected double _containerWeight { get; }
    protected double _depth { get; }
    protected string _seriesNumber { get; set; }
    protected double _maxLoad { get; }

    protected Container(double cargoWeight, double height, double containerWeight, double depth, double maxLoad)
    {
        _cargoWeight = cargoWeight;
        _height = height;
        _containerWeight = containerWeight;
        _depth = depth;
        _maxLoad = maxLoad;
    }
    
    

    public virtual void Unload()
    {
        _cargoWeight = 0;
    }

    public virtual void Load(double cargoWeight)
    {
        if (_cargoWeight + cargoWeight > _maxLoad)
            throw new OverFillException();
        _cargoWeight += cargoWeight;
    }

    public override string ToString()
    {
        return "Cargo weight = " + _cargoWeight + "\tMax load = "  + _maxLoad + "\tSeries number = " + _seriesNumber;
    }
}