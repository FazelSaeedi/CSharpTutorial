using baseCalculator;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculator calculator = new Calculator(@"D:\Projects\internship\Mission\Project1-Calculator\Calculator\historyFile.txt");
            calculator.Run();

        }
    }

}






