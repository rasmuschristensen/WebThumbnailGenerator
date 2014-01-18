using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebThumbnailGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var proc = new Process();
            proc.StartInfo.FileName = @"phantomjs.exe";
            proc.StartInfo.Arguments = string.Format("runner.js {0} {1}",
                "http://www.onlinebooq.dk", "onlinebooq");
            Console.WriteLine(proc.StartInfo.WorkingDirectory);
            proc.StartInfo.WorkingDirectory = @"phantomjs";

            proc.Start();
        }
    }
}
