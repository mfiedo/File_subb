using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace TMS_arch_sub
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            string path = "d:\\TMS_Arch\\TMS Archive replacer inputs\\TMS Archive replacer inputs\\FixedBilingualFiles\\";
            FileExtractor fileExtractor = new FileExtractor();
            DirectoryInfo inputFolder = new DirectoryInfo(path);
            var list = fileExtractor.ExtractFiles(inputFolder);
            
            Console.ReadKey();
        }
    }
}
