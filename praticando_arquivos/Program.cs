public class Program
{
    public static void Main(string[] args)
    {
        string pathData = @"/Users/rodrigo/Desktop/CSharp/praticando_arquivos/data/brasileirao-2004-2022.csv";
        List<string[]> data = new();

        if (File.Exists(pathData))
        {
            string[] dataVetor = File.ReadAllLines(pathData);

            foreach (string dt in dataVetor)
            {
                string[] lines = dt.Split(", ");
                data.Add(lines);
            }

            Console.Write("Qual time deseja pesquisar? ");
            string time = Console.ReadLine();

            data.Where(dt => dt[2].Equals(time) && int.Parse(dt[0]) >= 2006 && int.Parse(dt[1]) >= 17)
                .ToList()
                .ForEach(data =>
                {
                    foreach (string dt in data)
                    {
                        Console.Write(dt + " | ");
                    }
                    Console.WriteLine();
                });
        }

        Console.ReadKey();
    }
}
