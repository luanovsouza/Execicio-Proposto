using System.Globalization;

namespace Exercicio119.Entities;

public abstract class Person
{
    public string? Name { get; set; }
    public double AnualIncome { get; set; }
    
    protected Person(string? name, double anualIncome)
    {
        Name = name;
        AnualIncome = anualIncome;
    }


    public abstract double Income();

    public override string ToString()
    {
        return $"{Name}: $ {Income().ToString("F2", CultureInfo.InvariantCulture)}";
    }
}