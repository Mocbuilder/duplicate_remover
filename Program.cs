using System;
using System.IO;

public class text_duplicate_remover
{
    public static List<string> filePaths = new List<string>();
    public static string outputFilePath = "";
    public static List<string> lines = new List<string>();
    public static bool hasError = false;
    public static List<string> errorPaths = new List<string>();

    public static void Main(string[] args)
    {
        outputFilePath = args[0];
        if(!File.Exists(outputFilePath))
        {
            File.WriteAllText(outputFilePath, "");    
        }   

        for(int i = 1; i <= args.Length -1; i++)
        {
            string currentFilePath = File.Exists(args[i])? args[i] : null;

            if(currentFilePath == null)
            {
                hasError = true;
                errorPaths.Add(args[i]);      
                continue;
            }

            lines.AddRange(File.ReadAllLines(currentFilePath));
        }

        lines = lines.Distinct().ToList<string>();
        lines.Sort();

        File.WriteAllLines(outputFilePath, lines);

        Console.WriteLine($"Succesfully wrote {lines.Count()} unique results to: \n{outputFilePath}\n\n");
        if(hasError)
        {
            Console.WriteLine($"But had to skip {errorPaths.Count()} non-existant files:\n");
            foreach(string path in errorPaths)
            {
                Console.WriteLine($"Skipped File: {path}\n");
            }
        }

        Console.WriteLine("\n\nPress any key to exit...");
        Console.ReadKey();
    }
}