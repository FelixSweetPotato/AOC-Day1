using Day1;
using Day1.Parser;
using Day1.ParserFactory;

internal class Program
{
    //This is my code for the advent of code Day 1 part 1!
    //I'm an intermediate programmer, I'm doing aoc to practice 
    //and have fun during my christmas break. My solution is probably a bit 
    //over enginered, but I'm just trying to have fun. :)
    private static void Main(string[] args)
    {
        //Grabs file and extracts values
        InputsFectcher i = new InputsFectcher("inputs.txt");
        List<string> values = i.getValues();

        //Creates the parser
        ParserFactory pf = new ParserFactory();
        IStringParser sp = pf.createParser(typeof(int));
        //gets the value for each line and sums it in a total variable 
        int total = 0;
        foreach(string value in values){
            total+= sp.ParseNumberToInt(value);
        }
        //prints the answer
        Console.WriteLine("Le total est:"+ total);
    }
}