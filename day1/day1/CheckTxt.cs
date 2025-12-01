    namespace day1;
    
    public class CheckTxt()
    {
        public void CheckFile()
        {
            int milliseconds = 1000;
            string fileName = "input.txt";
            if (File.Exists(fileName))
            {
                if( new FileInfo( "input.txt" ).Length == 0 )
                    {
                    Console.WriteLine("input.txt found in: {0}", Directory.GetCurrentDirectory());
                    Console.WriteLine("file empty, exit programm....");
                    Environment.Exit(0);
                    }
                else
                    {
                    Console.WriteLine("input.txt found in {0}", Directory.GetCurrentDirectory());
                    Console.WriteLine("calculating, please wait little elf...");
                    Thread.Sleep(milliseconds);
                    Console.WriteLine("calculating...");
                    Thread.Sleep(milliseconds);
                    Console.WriteLine("calculating...");
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