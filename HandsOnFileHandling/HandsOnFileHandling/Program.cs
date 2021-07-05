using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HandsOnFileHandling
{
    class Program
    {
        static void Write(string file_path,string content)
        {
            try
            {
                File.WriteAllText(file_path, content);
            }
            catch(Exception ex)
            {
                // Console.WriteLine(ex.Message);
                // File.WriteAllText("E://err.txt", ex.Message);
                throw new ArgumentException("",ex);
            }
        }
        static void Div(int a,int b)
        {
            try
            {
                int c = a / b;

            }
            catch(DivideByZeroException ex)
            {
                throw new FileNotFoundException();
            }
        }
        static void Main(string[] args)
        {
            try
            {
                //Console.WriteLine("Enter File Path");
                //string path = Console.ReadLine();
                //Console.WriteLine("Enter Content");
                //string content = Console.ReadLine();
                //Write(path, content);
                Div(2, 0);
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
            }
        }
    }
}
