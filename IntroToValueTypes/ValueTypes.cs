namespace IntroToValueTypes;

internal class ValueTypes
{
    public int Number = 1;
    long noe = 0;

    float desimalTall = 1.0f; //nøyaktig
    double desimalTall1 = 1.01;
    decimal desimalTall3 = 1.01M; //veldig nøyaktig

    char bokstav = 'a';
    string tekst = "hei";

    bool santUsant = false;

    private int[] tallArray = { 1, 2, 3 };
    private string[] tekstArray = { "hei", "på", "deg" };

    List<int> listeMedTall = new List<int>(); //lager en ny liste med tall

    public static decimal RunNumbers()
    {
        int a = 5;
        decimal b = 3;
        decimal c = a + b;

        return c;
    }

    public static int RunNumbers2()
    {
        int a = 5;
        decimal b = 3;
        decimal c = a + b;

        return (int)c;
    }

    public static string RunText()
    {
        return "Den første returnerer decimal og den andre int";
    }
}