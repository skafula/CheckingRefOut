using CheckingRefOut;

internal class Program
{
    private static void Main(string[] args)
    {
        var instance1 = new ForMethods();

        // with ref modifier i have to intialize the variable and it's value will be modified in the method
        int refParam = 0;
        instance1.CheckingRef(ref refParam);
        Console.WriteLine(refParam);

        // with out modifier it doesn't neccessery to initialize the variable before, it's possible int the method parameter line. 
        // it helps to return 2 or more values (like bool with return and the value of the random).
        var trueOrFalse = instance1.CheckingOut(out int random);
        Console.WriteLine($"{trueOrFalse}, {random}");

        // as i defined random before in the CheckingOut method's parameterlist the variable is alive and is able to work with (it's in the stack??)
        random = 20;
        Console.WriteLine($"{trueOrFalse}, {random}");

        trueOrFalse = instance1.CheckingRef(ref random);
        Console.WriteLine($"{trueOrFalse}, {random}");

        // if i declare the variable it's still useable on the Method param's list without its type keyword.
        int random1;
        trueOrFalse = instance1.CheckingOut(out random1);
        Console.WriteLine(random1);
    }
}