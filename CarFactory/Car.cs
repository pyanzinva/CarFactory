using CarFactory;
using System;

class Car : ICar
{
    protected string Model;
    protected int Speed;

    public Car(string model)
    {
        Model = model;
        Speed = 0;
    }

    public void Accelerate()
    {
        Speed += 10;
        Console.WriteLine($"{Model} ускоряется. Текущая скорость: {Speed} км/ч");
    }

    public void Decelerate()
    {
        Speed -= 10;
        Console.WriteLine($"{Model} замедляется. Текущая скорость: {Speed} км/ч");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Автомобиль {Model} имеет скорость {Speed} км/ч");
    }
}
