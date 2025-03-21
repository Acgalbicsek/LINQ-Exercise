namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGameNames = new List<string> { "Arena", "Daggerfall", "Morrowwind", "Oblivion", "Skyrim", "VI" };
            var lengthOfGameNames = videoGameNames.OrderBy(name => name.Length);
            foreach (var name in lengthOfGameNames)
            {
                Console.WriteLine(name);

            }
        }
    }
}
