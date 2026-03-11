using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp14Demo;

public static class PartialMembersDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Partial Members Demo ===\n");

        var calculator = new Calculator();
        var result = calculator.Add(5, 3);

        Console.WriteLine($"Result: {result}");
    }
}

public partial class Calculator
{
    public int Add(int a, int b)
    {
        Log($"Adding {a} and {b}");
        return a + b;
    }

    // C# 14 allows accessibility + return type
    public partial string Log(string message);
}

// Implementation part
public partial class Calculator
{
    public partial string Log(string message)
    {
        Console.WriteLine($"LOG: {message}");
        return message;
    }
}
