namespace Extensions;

public static class ExtensionMethods
{
    public static int NumberOfSpace(this string msg)
    {
        var n = msg.Split(' ').Length - 1;
        return n;
    }
}
