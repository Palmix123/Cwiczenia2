// See https://aka.ms/new-console-template for more information

using ConsoleApp1;
using ConsoleApp1.Containers;
using ConsoleApp1.Ships;

LiquidContainer liquidContainer = new LiquidContainer(0, 3,100,6,2000, PossibleProducts.Bananas, false);
liquidContainer.Load(112);
Ship ship = new Ship(liquidContainer, 5, 400, 1241411);

Console.WriteLine(liquidContainer);
Console.WriteLine(ship);
ship.UnloadContainer(liquidContainer);
Console.WriteLine(ship);
