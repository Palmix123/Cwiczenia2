using ConsoleApp1.Containers;

namespace ConsoleApp1.Ships;

public class Ship
{
    private List<Container> _containers { get; set; } = new();
    private double _maxSpeed { get; set; }
    private int _maxContainers { get; set; }
    private double _maxWeight { get; set; }

    public Ship(Container container, double maxSpeed, int maxContainers, double maxWeight)
    {
        _containers.Add(container);
        _maxSpeed = maxSpeed;
        _maxContainers = maxContainers;
        _maxWeight = maxWeight;
    }

    public void UnloadContainer(Container container)
    {
        if (_containers.Contains(container))
            _containers.Remove(container);
        else
            Console.WriteLine("No such container");
    }
    
    public void AddContainer(Container container)
    {
        _containers.Add(container);
    }

    public void AddContainers(List<Container> containers)
    {
        _containers.AddRange(containers);
    }
    
    public void ChangeContainer(Container delete, Container insert)
    {
        int index = _containers.FindIndex(c => c.Equals(delete));
        if (index != -1)
            _containers[index] = insert;
        else
            Console.WriteLine("No such container");
    }

    public void ChangeShip(Ship newShip, Container container)
    {
        if (_containers.Contains(container))
            newShip.AddContainer(container);
        else
            Console.WriteLine("No such container");
    }

    public override string ToString()
    {
        string containersString = "";
        foreach (var container in _containers)
        {
            containersString += container + "\n";
        }
        return "Ship containers: " + containersString;
    }
}