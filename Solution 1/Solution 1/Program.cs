using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_1
{
    class ReadFromFile
{
    static void Main()
    {
        string text = System.IO.File.ReadAllText(@"H:demo.txt");

        System.Console.WriteLine("Contents of WriteText.txt = {0}", text);
           
        string[] lines = System.IO.File.ReadAllLines(@"H:demo.txt");
        System.Console.WriteLine();
        System.Console.ReadKey();
    }
}
}