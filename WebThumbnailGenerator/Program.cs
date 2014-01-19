using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebThumbnailGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ready to capture screenshot");

            var proc = new Process();
            proc.StartInfo.FileName = @"phantomjs.exe";
            proc.StartInfo.Arguments = "runner.js";
            //proc.StartInfo.Arguments = string.Format("runner.js {0} {1}",
            //    "http://www.onlinebooq.dk", "onlinebooq");
            Console.WriteLine(proc.StartInfo.WorkingDirectory);
            proc.StartInfo.WorkingDirectory = @"phantomjs";
            
            


            try
            {
                var processStarted = proc.Start();
                var waitproc = proc.WaitForExit(15000);
            
            
            Console.WriteLine("Process ran " + processStarted);
            Console.WriteLine("Process wait " + waitproc);
            Console.WriteLine("Done capturing screenshot");
            Console.WriteLine("phantom exists? " + File.Exists("phantomjs/phantomjs.exe"));
            Console.WriteLine("Image exists? " + File.Exists("phantomjs/webname.png"));
            Console.WriteLine("Image exists? " + File.Exists("phantomjs/webname.png"));
            var files = Directory.GetFiles("phantomjs");
            
            string allfiles = string.Join(",", files);
            Console.WriteLine("all files: " + allfiles);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.StackTrace);

            }
        }
    }
}
