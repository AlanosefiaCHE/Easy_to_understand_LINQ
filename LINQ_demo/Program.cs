using System;

namespace MyApp 

{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<Persoon>people = ListManager.LoadSampleData();
            /*
             * OrderBy return een enum daarom wordt .ToList toegevoegd
             */
           var peopleOrder = people.OrderBy(x => x.FirstName).ToList();
           var peopleFilter = people.Where(x => x.YearsWorking > 5 && x.YearsWorking <= 10).ToList();
           int YearsExp = people.Sum(x => x.YearsWorking);
           int YearsExpHard = people.Where(x => x.Birthday.Month == 10).Sum(x => x.YearsWorking);



           Console.WriteLine("Order By LINQ");

           foreach (var person in peopleOrder)
           {
               Console.WriteLine(
                   $"{person.FirstName} {person.LastName} {person.Birthday.ToShortDateString()} {person.YearsWorking}");
           }

           Console.WriteLine("____________________________________________________");
            Console.WriteLine("Filter LINQ");
            Console.WriteLine("Allesn filtere tussen 5 en 10 jaar werkervaring");
            Console.WriteLine();
            foreach (var person in peopleFilter)
            {
                Console.WriteLine(
                    $"{person.FirstName} {person.LastName} {person.Birthday.ToShortDateString()} {person.YearsWorking}");
            }
            Console.WriteLine("____________________________________________________");
            Console.WriteLine("Sum LINQ");
            Console.WriteLine("Alle werkervaringen optellen");
            Console.WriteLine($"Totaal werkervaring is {YearsExp}");
            Console.WriteLine("____________________________________________________");
            Console.WriteLine("Sum LINQ");
            Console.WriteLine("Alle werkervaringen optellen waarbij de mensen in maand 10 zijn geboren");
            Console.WriteLine($"Totaal werkervaring is {YearsExpHard}");
        }
    }


}