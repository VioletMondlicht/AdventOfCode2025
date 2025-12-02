namespace day2;

public class ProductIdSolver
{
  
    public void IdSolver()
    {
        long totalSum = 0;
        Console.WriteLine("Reading input.txt, please wait...");
        string input = File.ReadAllText("input.txt");
        string[] range = input.Trim().Split(',',StringSplitOptions.RemoveEmptyEntries);
        

        foreach (string line in range)
        {
            string[] IDs = line.Split('-');
            long.TryParse(IDs[0], out long startID);
            long.TryParse(IDs[1], out long endID);
            for (long i = startID; i <= endID; i++)
            {
                string IDstruct = i.ToString();
                if (IDstruct.Length %2 == 0 )
                {
                    int halfLength = IDstruct.Length/2;
                    string firsthalf = IDstruct.Substring(0, halfLength);
                    string secondhalf = IDstruct.Substring(halfLength);
                    if (firsthalf == secondhalf)
                    {
                        totalSum = totalSum+i;
                    }
                }
            }
        }
        Console.WriteLine($"{totalSum}");
    }
}