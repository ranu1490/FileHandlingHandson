using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileHandlingHandson
{
    class FailedFileHandling
    {
        public void ReadFile()
        {
            FileStream fileStream = new FileStream(@"C:\Users\HP\source\repos\30-3-2022Handson\networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            Console.WriteLine("ID\t\tSource\t\tDestination\t\tDate\t\tTime\t\tStatus\t\tNetwork");
            while (reader.Peek() > 0)
            {
                var Id = reader.ReadLine();
                string[] netIdStr = Id.Split(':');
                int id = Convert.ToInt32(netIdStr[1]);

                var source = reader.ReadLine();
                string[] sourceStr = source.Split(':');
                string src = sourceStr[1];

                var dest = reader.ReadLine();
                string[] desStr = dest.Split(':');
                string des = desStr[1];

                var time = reader.ReadLine();
                string[] tStr = time.Split(' ');
                string times = tStr[1];
                string mode = tStr[2];
                string[] tStr1 = tStr[0].Split(':');
                string date = tStr1[1];

                var stat = reader.ReadLine();
                string[] statStr = stat.Split(':');
                string status = statStr[1];

                var net = reader.ReadLine();
                string[] nettStr = net.Split(':');
                string network = nettStr[1];

                if (id > 0)
                {
                    if (status.Contains("Failed"))
                        Console.WriteLine(id + "\t\t" + src + "\t" + des + "\t\t" + date + "\t" + times + "\t" + mode + "\t" + status + "\t\t" + network);

                }
                reader.ReadLine();
            }
        }
    }
}
