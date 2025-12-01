using System.Security.Cryptography.X509Certificates;

namespace day1;

public class Programm
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Heyho and welcome to the Northpole little elf!");
        Console.WriteLine("This is the Password-Decrypter by VioletMondlicht");
        Console.WriteLine("https://github.com/VioletMondlicht");
        Console.WriteLine("Robot will check if input.txt exist, please wait...");
        Console.WriteLine("");

        CheckTxt check = new();
        check.CheckFile();
    }
}
