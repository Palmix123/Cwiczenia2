using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Containers;

public class GasContainer : Container, IHazardNotifier
{
    private static int _index { get; set; }
    private Enum _substance { get; set; }
    private double _preassure { get; set; }

    public GasContainer(double cargoWeight, double height, double containerWeight, double depth, double maxLoad, PossibleProducts substance, double preassure) : base(cargoWeight, height, containerWeight, depth, maxLoad)
    {
        _seriesNumber = ("KON-G-" + _index++);
        _substance = substance;
        _preassure = preassure;
    }

    public override void Unload()
    {
        _cargoWeight *= 0.05;
    }

    public void NotifyDangerousSituation()
    {
        Console.WriteLine("Dangerous situation in container " + _seriesNumber);
    }
    
    
}