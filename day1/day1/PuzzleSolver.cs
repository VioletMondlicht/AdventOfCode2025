namespace day1;

public class PuzzleSolver
{
    public int currentPosition = 50;
    public int password = 0;
    public void SolvePuzzle()
    {
        Console.WriteLine("Reading input.txt, please wait...");
        string[] input = File.ReadAllLines("input.txt");

    foreach(string line in input)
        {
            if (line[0] == 'L')
            {
                int.TryParse(line.Substring(1), out int command);
                
                currentPosition = (currentPosition-command)%100;
                if (currentPosition < 0)
                {
                    currentPosition = currentPosition+100;
                }
            }
            else if (line[0] == 'R')
            {
                int.TryParse(line.Substring(1), out int command);

                currentPosition = (currentPosition+command)%100;
            }
            if (currentPosition == 0)
                {
                    password++;
                }
            }
        Console.WriteLine($"{password}");
        }
    }