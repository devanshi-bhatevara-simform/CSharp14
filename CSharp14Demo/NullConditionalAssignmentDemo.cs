using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp14Demo;

public static class NullConditionalAssignmentDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Null-Conditional Assignment Demo ===\n");

        Logger? logger = new Logger();

        // OLD
        if (logger != null)
        {
            logger.Message = "Processing started (OLD)";
        }

        Console.WriteLine("OLD assignment completed.");

        // NEW
        logger?.Message = "Processing started (NEW)";
        Console.WriteLine("NEW assignment completed.");
    }
}

public class Logger
{
    public string? Message { get; set; }
}
