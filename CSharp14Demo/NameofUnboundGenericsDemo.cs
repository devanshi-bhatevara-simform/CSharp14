namespace CSharp14Demo;

public static class NameofUnboundGenericsDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Improved nameof with Unbound Generic Types Demo ===\n");

        // OLD Way (Pre-C# 14) — required a concrete type argument
        Console.WriteLine("OLD Way:");
        Console.WriteLine($"  nameof(List<int>)        = {nameof(List<int>)}");
        Console.WriteLine($"  nameof(Dictionary<int,int>) = {nameof(Dictionary<int, int>)}");

        // NEW Way (C# 14) — unbound generic types work directly
        Console.WriteLine("\nNEW Way (C# 14):");
        Console.WriteLine($"  nameof(List<>)           = {nameof(List<>)}");
        Console.WriteLine($"  nameof(Dictionary<,>)    = {nameof(Dictionary<,>)}");
    }
}
