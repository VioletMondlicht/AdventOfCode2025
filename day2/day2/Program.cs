namespace day2;

public class Programm
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Heyho and welcome to the gift shop!");
        Console.WriteLine("This is the Product-ID-Checker by VioletMondlicht");
        Console.WriteLine("https://github.com/VioletMondlicht");
        Console.WriteLine("Robot will check if input.txt exist, please wait...");
        Console.WriteLine("");

        CheckTxt check = new();
        check.CheckFile();

        ProductIdSolver checkID = new();
        checkID.IdSolver();
    }
}