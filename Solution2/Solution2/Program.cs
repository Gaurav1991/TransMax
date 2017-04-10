using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class ReadFromFile
{
    static void Main()
    {
        string text = System.IO.File.ReadAllText(@"H:demo.txt");

        System.Console.WriteLine("Contents of WriteText.txt = {0}", text);

        List<string> list = new List<string>();
        using (StreamReader reader = new StreamReader(@"H:demo.txt"))
        {
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split(',');
                Array.Sort(parts);
                // Array.Reverse(parts);
                list.Add(string.Join(" ", parts));
            }
        }

        list.Sort(new NameComparer());
        using (StreamWriter writer = new StreamWriter("opfile.txt"))
        {
            foreach (var line in list)
                writer.WriteLine(line);
        }
                System.Console.WriteLine("Press any key to exit.");
        System.Console.ReadKey();
    }
    public class NameComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            if (x == null && y == null) return 0;

            if (x == null || y == null) return -1;

            var parts1 = x.Split();
            var parts2 = y.Split();

            if (parts1.Length > 1 && parts2.Length > 1)
            {
                if (parts1[0] != parts2[0]) return parts1[0].CompareTo(parts2[0]);

                return parts1[1].CompareTo(parts2[1]);
            }

            return x.CompareTo(y);
        }
    }
}
