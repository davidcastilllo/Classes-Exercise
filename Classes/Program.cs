namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var toyota = new Car();
            
            toyota.Make = "Toyota";
            toyota.Model = "Tacoma";
            toyota.Year = 2004;
            
            Console.WriteLine($"This is a {toyota.Make} {toyota.Model} and it was made in the year {toyota.Year}");
        }
    }
}
