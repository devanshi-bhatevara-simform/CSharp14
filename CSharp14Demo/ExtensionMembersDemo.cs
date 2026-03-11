using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp14Demo;

public static class ExtensionMembersDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Extension Members Demo ===\n");

        string text = "Welcome to CSharp 14 demo session";

        // OLD way (C# before 14)
        Console.WriteLine("OLD Way:");
        Console.WriteLine($"Word Count: {StringExtensionsOld.WordCount(text)}");

        // NEW way (C# 14 Extension Members)
        Console.WriteLine("\nNEW Way (C# 14 Extension Members):");
        Console.WriteLine($"Word Count: {text.WordCount}");
    }
}

// OLD Extension Style (Pre-C# 14)
public static class StringExtensionsOld
{
    public static int WordCount(string value)
        => value.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
}

// NEW C# 14 Extension Members
// Must be inside a top-level static class container
public static class StringExtensions
{
    extension(string value)
    {
        public int WordCount =>
            value.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    }
}
