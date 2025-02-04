namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Toyota = new Car();
            
            Toyota.Make = "Toyota";
            Toyota.Model = "Tacoma";
            Toyota.Year = 2004;
            
            Console.WriteLine($"This is a {Toyota.Make} {Toyota.Model} and it was made in the year {Toyota.Year}");
        }
    }
}
