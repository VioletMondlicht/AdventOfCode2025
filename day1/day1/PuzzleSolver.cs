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
                
                int newCurrentPosition = currentPosition - command;
                if (newCurrentPosition < 0)
                {
                    newCurrentPosition = newCurrentPosition+100;
                }
                currentPosition = newCurrentPosition;
            }
            if (line[0] == 'R')
            {
                int.TryParse(line.Substring(1), out int command);

                int newCurrentPosition = (currentPosition+command)%100;
                currentPosition = newCurrentPosition;
            }

            if (currentPosition == 0)
                {
                    password++;
                }
        }
    Console.WriteLine($"{password}");

    }
}