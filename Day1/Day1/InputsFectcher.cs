using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    public class InputsFectcher
    {
        private string _fileName;

        public InputsFectcher(string fileName)
        {
            _fileName= fileName;
        }
        //returns each lines of the file in a string list
        //I have to say: I hate the file reading syntax in C# (not intuitive at all)
        public List<string> getValues()
        {
            List<string> values = new List<string>();

            using ( StreamReader sr = new StreamReader(Directory.GetCurrentDirectory()+"\\" +_fileName ))
            {
                while (!sr.EndOfStream)
                {
                    values.Add(sr.ReadLine());
                }
                
            }

            

            return values;
        }
    }
}
