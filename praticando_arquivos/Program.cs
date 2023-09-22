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
        }

        Console.ReadKey();
    }
}
