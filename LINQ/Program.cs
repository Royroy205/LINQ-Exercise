namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var gameNames =new List<string>() 
            { 
                "Midnight Club",
                "Left Dead 2",
                "Need For Speed",
                "Mortal Kombat",
                "Frog",
            
            
            };

            gameNames.OrderBy(x => x.Length).ToList() .ForEach(x => Console.WriteLine(x));

        }
    }
}
