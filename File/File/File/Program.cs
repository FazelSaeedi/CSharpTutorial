using System;
using System.IO ;
using System.Text;

namespace file
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            string fileName = @"D:\Projects\internship\Mission\File\File\fileTest.txt";
            // Check if file already exists. If yes, delete it.     
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }



            // Create a new file     
            using (FileStream fs = File.Create(fileName))
            {
                // Add some text to file    
                Byte[] title = new UTF8Encoding(true).GetBytes("New Text File \n");
                fs.Write(title, 0, title.Length);
            }




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


            //var fileExist = File.Exists(@"D:\Projects\internship\Mission1\File\File\File.sln");
            // var readAllText = File.ReadAllText(@"D:\Projects\internship\Mission1\File\File\File.sln");
        }
    }
}
