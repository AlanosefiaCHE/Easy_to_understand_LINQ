namespace MyApp;

public class ListManager
{
    public static List<Persoon> LoadSampleData()
    {
        List<Persoon> output = new List<Persoon>();

        output.Add(new Persoon{FirstName = "Jan", LastName = "Blaak", Birthday = Convert.ToDateTime("2/05/2001"), YearsWorking = 8 });
        output.Add(new Persoon{FirstName = "Pieter", LastName = "Jansen", Birthday = Convert.ToDateTime("1/12/2005"), YearsWorking = 20});
        output.Add(new Persoon{FirstName = "Alan", LastName = "Osefia", Birthday = Convert.ToDateTime("20/04/2001"), YearsWorking = 5 });
        output.Add(new Persoon{FirstName = "Merel", LastName = "Bakker", Birthday = Convert.ToDateTime("1/02/2001"), YearsWorking = 1 });
        output.Add(new Persoon{FirstName = "Samir", LastName = "Hoeven", Birthday = Convert.ToDateTime("1/10/1995"), YearsWorking = 8 });
        output.Add(new Persoon{FirstName = "Lisa", LastName = "Bente", Birthday = Convert.ToDateTime("1/10/1995"), YearsWorking = 7 });
        output.Add(new Persoon{FirstName = "Ayoub", LastName = "Oqla", Birthday = Convert.ToDateTime("1/10/1995"), YearsWorking = 9 });
        output.Add(new Persoon{FirstName = "Jonas", LastName = "Boekema", Birthday = Convert.ToDateTime("1/10/1995"), YearsWorking = 9 });

        return output;
    }

    public static void GetList(List<Persoon> people)
    {

       

    }
}


