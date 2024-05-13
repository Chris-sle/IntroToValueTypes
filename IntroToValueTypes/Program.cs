using IntroToValueTypes;

class Program
{
    static void Main()
    {
        // executes the static methods directly
        decimal NewNumber = ValueTypes.RunNumbers();
        int NewNumber2;
        NewNumber2 = ValueTypes.RunNumbers2();
        string NewString = ValueTypes.RunText();

        // should display both outputs in the console
        Console.WriteLine(NewNumber);
        Console.WriteLine(NewNumber2);
        Console.WriteLine(NewString); // Should output "This is a string"
    }
}