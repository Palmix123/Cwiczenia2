using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Containers;

public class LiquidContainer : Container, IHazardNotifier
{
    private static int _index { get; set; }
    private Enum _substance { get; set; }
    private bool _isDangerous;
    
    public LiquidContainer(double cargoWeight, double height, double containerWeight, double depth, double maxLoad, PossibleProducts substance, bool isDangerous) : base(cargoWeight, height, containerWeight, depth, maxLoad)
    {
        _seriesNumber = ("KON-L-" + _index++);
        _substance = substance;
        _isDangerous = isDangerous;
    }
    
    public void NotifyDangerousSituation()
    {
        Console.WriteLine("Dangerous situation in container " + _seriesNumber);
    }

    public override void Load(double cargoWeight)
    {
        if (_isDangerous && _cargoWeight + cargoWeight < _maxLoad / 2)
            _cargoWeight += cargoWeight;
        else if (!_isDangerous && _cargoWeight + cargoWeight < _maxLoad * 0.9)
            _cargoWeight += cargoWeight;
        else
        {
            Console.WriteLine("Danger load!!! Aborted.");
        }
    }
}