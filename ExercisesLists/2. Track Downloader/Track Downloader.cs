using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Track_Downloader
{
    class Program
    {
        static void Main(string[] args)
        {
            var blackList = Console.ReadLine().Split(' ').ToList();
            var fileList = new List<string>();
            
            string filesName = string.Empty;
            while (true)
            {
                filesName = Console.ReadLine();

                if (filesName == "End")
                {
                    break;
                }

                fileList.Add(filesName);
            }

            var fileList2 = new List<string>();

            for (int i = 0; i < fileList.Count; i++)
            {
                for (int ii = 0; ii < blackList.Count; ii++)
                {
                    if (fileList[i].Contains(blackList[ii]))
                    {
                        //ii = 0;
                        break;
                    }
                    else if(ii == blackList.Count-1)
                    {
                        fileList2.Add(fileList[i]);
                    }
                    
                }
                
            }
            fileList2.Sort();
            //Console.WriteLine(string.Join("\n",fileList2));
            foreach (var name in fileList2)
            {
                Console.WriteLine(name);
            }
        }
    }
}
