namespace Ejecicio;

using System;

public abstract class Tie
{
    private Material _material;

    public Material Material
    {
        get => _material;
        set => _material = value;
    }

    public abstract double CalculateArea();
}


