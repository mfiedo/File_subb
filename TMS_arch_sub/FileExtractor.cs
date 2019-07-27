using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Linq;

namespace TMS_arch_sub
{
    public class FileExtractor
    {
        public string ExtractFiles(DirectoryInfo inputfolder)
        {


            FileInfo[] filePaths = inputfolder.GetFiles("*.sdlxliff", SearchOption.AllDirectories);
            foreach (FileInfo file in filePaths)
            {
                //DateTime timeWritten = file.LastWriteTimeUtc;
                /*XmlReader xRead = XmlReader.Create(file.FullName);
                XElement xEle = XElement.Load(xRead);
                
                xRead.Close();*/
                
                XDocument xmlStr = XDocument.Load(file.FullName);
                XNamespace namespac = "http://sdl.com/FileTypes/SdlXliff/1.0";
                XElement origPath = from origp in xmlStr.namespac.Root
                                    where o => o.Name == "file"
                                    select node => new { original = node.Attribute("original").Value, 
                                                         tarlang = node.Attribute("target-language").Value};
                /*XElement origPath = 
                    from origp in xmlStr.Root.Elements("file")
                    where (string)origp.Attribute("original") != null
                    select origp.Attribute("original");*/
                Console.WriteLine();
            }
            return null;
        }
            
    }
}
