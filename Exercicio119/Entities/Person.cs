namespace Exercicio119.Entities;

public abstract class Person
{
    public string? Name { get; set; }
    public double AnualIncome { get; set; }
    public double HealthSpending { get; set; }


    protected Person(string? name, double anualIncome, double healthSpending)
    {
        Name = name;
        AnualIncome = anualIncome;
        HealthSpending = healthSpending;
    }


    public abstract double Income();
}