using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp14Demo;

public static class FieldKeywordDemo
{
    public static void Run()
    {
        Console.WriteLine("=== field Keyword Demo ===\n");

        // OLD
        var oldPerson = new PersonOld();
        oldPerson.Name = "Akash";
        Console.WriteLine($"OLD Person Name: {oldPerson.Name}");

        // NEW
        var newPerson = new PersonNew();
        newPerson.Name = "Akash";
        Console.WriteLine($"NEW Person Name: {newPerson.Name}");
    }
}

// OLD Style
public class PersonOld
{
    private string _name = string.Empty;

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty");

            _name = value;
        }
    }
}

// NEW C# 14 Style
public class PersonNew
{
    public string Name
    {
        get;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty");

            field = value;   // C# 14
        }
    }
}
