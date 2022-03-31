using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingHandson
{
    internal class FileHandling
    {
        public void ReadFile()
        {
            FileStream fileStream = new FileStream(@"C:\Users\HP\source\repos\30-3-2022Handson\networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            Console.WriteLine("Id\tSource\t\tDestination\t\tDate\t\t\t\t\tStatus\t\tNetwork");
            while (reader.Peek() > 0)
            {

                var id = reader.ReadLine();
                string[] IdStr = id.Split(':');
                string nid = IdStr[1];

                var source = reader.ReadLine();
                string[] SourceStr = source.Split(':');
                string Source = SourceStr[1];

                var dest = reader.ReadLine();
                string[] destStr = dest.Split(':');
                string Dest = destStr[1];

                string Date = reader.ReadLine();
                string date="";
                string time="";
                if (Date.StartsWith("Date"))
                {
                    date = Date.Split(' ')[0].Split(':')[1];
                    time = Date.Split(' ')[1]+" "+Date.Split(' ')[2];
                }

                var status = reader.ReadLine();
                string[] StatusStr = status.Split(':');
                string Status = StatusStr[1];

                var network = reader.ReadLine();
                string[] ntwkStr = network.Split(':');
                string ntwk = ntwkStr[1];

                Console.WriteLine(nid + "\t" + Source + "\t" + Dest + "\t\t" + date + "\t"+time+ "\t\t" + Status + "\t\t" + ntwk);

                reader.ReadLine();

            }
        }
    }
}
