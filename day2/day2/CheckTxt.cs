namespace day2;
public class CheckTxt()
{
    public void CheckFile()
    {
        string fileName = "input.txt";
        if (File.Exists(fileName))
        {
            if( new FileInfo( "input.txt" ).Length == 0 )
                {
                Console.WriteLine("input.txt found in: {0}", Directory.GetCurrentDirectory());
                Console.WriteLine("File empty, exit programm....");
                Environment.Exit(0);
                }
            else
                {
                Console.WriteLine("input.txt found in {0}", Directory.GetCurrentDirectory());
                Console.WriteLine("checking product-IDs, please wait little elf...");
                }
        }
        else
        {
            Console.WriteLine($"{fileName} not found!");
            Console.WriteLine("Please put file into this dir: {0}", Directory.GetCurrentDirectory());
            Console.WriteLine($"Exit programm...");
            Environment.Exit(0);
        }
    }
}