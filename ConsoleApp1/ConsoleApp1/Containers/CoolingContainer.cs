namespace ConsoleApp1.Containers;

public class CoolingContainer : Container
{
    private static int _index { get; set; }
    private Enum _substance { get; set; }
    private double _temeratue  { get; set; }
    private static Dictionary<PossibleProducts, Double> _productsList = new();
    public CoolingContainer(double cargoWeight, double height, double containerWeight, double depth, double maxLoad, PossibleProducts substance, double temperature) : base(cargoWeight, height, containerWeight, depth, maxLoad)
    {
        if (_productsList.Count == 0)
        {
            _productsList.Add(PossibleProducts.Bananas, 13.3);
            _productsList.Add(PossibleProducts.Chocolate, 18);
            _productsList.Add(PossibleProducts.Fish, 2);
            _productsList.Add(PossibleProducts.Meat, -15);
            _productsList.Add(PossibleProducts.IceCream, -18);
        }
        if (_productsList.GetValueOrDefault(substance) > temperature)
        {
            double tmp = _productsList.GetValueOrDefault(substance);
            throw new ArgumentException("To low temperature for this product, must me at least " + tmp);
        }
        
        _seriesNumber = ("KON-C-" + _index++);
        _substance = substance;
        _temeratue = temperature;
    }
}