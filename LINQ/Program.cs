namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {


            var GameList = new List<string>()
            {
                "Oblivion", "Skyrim", "Child Of Light", "Zoo Tycoon", "Rayman"
            };



            

            var result = GameList.OrderBy(NameLength => NameLength.Count()).ToList();


           foreach(var Game in result)
            {
                Console.WriteLine(Game);
            }

        }

        
    }
}
