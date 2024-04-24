
string s = "Salomlar ";
string str = s.Say("hi");
Console.WriteLine(str);
public static class StringExtension
{
    public static string Say(this string str, string message)
    {

        return str + message;
    }
}