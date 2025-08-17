using System.Globalization;

namespace Exercicio119.Entities;

public  class Individual : Person
{
    private double HealthSpending { get; set; }
    
    public Individual(string? name, double anualIncome, double healthSpending) 
        : base(name, anualIncome)
    {
        HealthSpending = healthSpending;
    }

    public override double Income()
    {
        double maxincome = 20000.00;
        double sum = 0;
        
        if (AnualIncome <= maxincome && HealthSpending > 0.0)
        {
            double tax = 0.15;

            sum += (AnualIncome * tax) - (HealthSpending * 0.5);
        }
        
        else if (AnualIncome >= maxincome && HealthSpending > 0.0)
        {
            double tax = 0.25;

            sum += (AnualIncome * tax) - (HealthSpending * 0.5);
        }
        
        else if (AnualIncome <= maxincome)
        {
            double tax = 0.15;
            
            sum = AnualIncome * tax;
        }
        
        else
        {
            double tax = 0.25;
            sum = AnualIncome * tax;
        }

        return sum;
    }
}