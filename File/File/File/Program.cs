using System;
using System.IO ;
using System.Text;

namespace File
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        /*      
              AppendText()	    Appends text at the end of an existing file
              Copy()	        Copies a file
              Create()	        Creates or overwrites a file
              Delete()	        Deletes a file
              Exists()	        Tests whether the file exists
              ReadAllText()	    Reads the contents of a file
              Replace()	        Replaces the contents of a file with the contents of another file
              WriteAllText()	Creates a new file and writes the contents to it. If the file already exists, it will be overwritten.
         */

            var fileExist = System.IO.File.Exists(@"D:\Projects\internship\Mission1\File\File\File.sln");
            var readAllText = System.IO.File.ReadAllText(@"D:\Projects\internship\Mission1\File\File\File.sln");
        }
    }
}
