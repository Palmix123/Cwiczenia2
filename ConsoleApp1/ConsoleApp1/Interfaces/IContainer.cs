﻿namespace ConsoleApp1.Interfaces;

public interface IContainer
{
    void Unload();
    void Load(double cargoWeight);
}