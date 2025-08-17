using System.Globalization;
using Exercicio119.Entities;

namespace Exercicio119
{
    public class Program
    {
        static void Main(string[] args)
        {
            Individual individual;
            LegalEntity legalentity;
            List<Person> persons = new List<Person>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{i+1} data: ");

                Console.Write("Indiviual or Company (i/c)? ");
                char classperson = char.Parse(Console.ReadLine()!);

                if (char.ToLower(classperson) == 'i')
                {
                    Console.Write("Name: ");
                    string? name = Console.ReadLine();

                    Console.Write("Anual Income: ");
                    double anualincome = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

                    Console.Write("Health Expenditures: ");
                    double healthexpenditures = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

                    individual = new Individual(name, anualincome, healthexpenditures);
                    persons.Add(individual);
                }
                
                else if (char.ToLower(classperson) == 'c')
                {
                    Console.Write("Name: ");
                    string? name = Console.ReadLine();

                    Console.Write("Anual Income: ");
                    double anualincome = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

                    Console.Write("Number of employees: ");
                    int numberemployee = int.Parse(Console.ReadLine()!);

                    legalentity = new LegalEntity(name, anualincome, numberemployee);
                    persons.Add(legalentity);
                }

                Console.WriteLine();
            }

            Console.WriteLine("TAXES PAID: ");
            
            foreach (Person person in persons)
            {
                Console.WriteLine(person);        
            }
        }
    }
}