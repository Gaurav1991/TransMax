﻿using System;

public class SimpleFileCopy
{
    static void Main()
    {
        string fileName = "demo.txt";
        string sourcePath = @"H:\";
        string targetPath = @"H:\1751";

        string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
        string destFile = System.IO.Path.Combine(targetPath, fileName);

        if (!System.IO.Directory.Exists(targetPath))
        {
            System.IO.Directory.CreateDirectory(targetPath);
        }

        System.IO.File.Copy(sourceFile, destFile, true);

        if (System.IO.Directory.Exists(sourcePath))
        {
            string[] files = System.IO.Directory.GetFiles(sourcePath);

            foreach (string s in files)
            {

                fileName = System.IO.Path.GetFileName(s);
                destFile = System.IO.Path.Combine(targetPath, fileName);
                System.IO.File.Copy(s, destFile, true);
            }
        }
        else
        {
            Console.WriteLine("Source path does not exist!");
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}