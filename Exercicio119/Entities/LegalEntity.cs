using System.Globalization;

namespace Exercicio119.Entities;

public class LegalEntity : Person
{
    public int EmployeeNumbers { get; set; }

    public LegalEntity(string? name, double anualIncome, int employeeNumbers) 
        : base(name, anualIncome)
    {
        EmployeeNumbers = employeeNumbers;
    }


    public override double Income()
    {
        double sum = 0;
        
        if (EmployeeNumbers >= 10)
        {
            double tax = 0.14;

            sum += (AnualIncome * tax);
        }
        
        else
        {
            double tax = 0.16;

            sum += (AnualIncome * tax);
        }

        return sum;
    }

    public override string ToString()
    {
        return base.ToString() + Income().ToString("F2", CultureInfo.InvariantCulture);
    }
}