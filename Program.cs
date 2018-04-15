using System;
using System.Collections.Generic;
using System.IO;
namespace textWriter
{
    class Program
    {
       
        static void Main(string[] args)
        {
        string inputFile = args[0];
        string line = "";
        List<string> tmpBuffer = new List<string>();

            if(args.Length>0){
                using (StreamReader sr = new StreamReader (inputFile))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        string [] newLine = line.Split(' ');
                        string tmpLine ="";
                        foreach (string element in newLine)
                        {
                            tmpLine += element+",";
                            
                        }
                        tmpBuffer.Add(tmpLine.Remove(tmpLine.Length-1));
                    }

                    
                }
                
                string fileName = inputFile.Replace("txt", "csv");
                File.WriteAllLines(fileName, tmpBuffer);
            }else{
                Console.WriteLine("Must giveme the file name");
            }
            
        }
    }
}
