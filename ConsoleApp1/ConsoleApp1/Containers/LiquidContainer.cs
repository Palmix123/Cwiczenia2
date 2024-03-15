namespace ConsoleApp1;

public class LiquidContainer : Container
{
    public LiquidContainer(double cargoWeight) : base(cargoWeight)
    {
        
    }
    
    public override void Load(double cargoWeight)
    {
        base.Load(cargoWeight);
        throw new NotImplementedException();
    }
}