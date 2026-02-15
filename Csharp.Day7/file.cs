using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Day7
{



    public class File : IReadable, IWritable
    {
        public string FileName { get; set; }

        public File(string fileName)
        {
            FileName = fileName;
        }

        public void Read()
        {
            Console.WriteLine($"Reading from {FileName}...");
        }

        public void Write()
        {
            Console.WriteLine($"Writing to {FileName}...");
        }
    }
}
