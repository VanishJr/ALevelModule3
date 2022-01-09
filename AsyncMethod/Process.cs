using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncMethod
{
    class Process
    {

        public async Task<string> HelloAsync()
        {
            string Hellotxt = null;
            using (StreamReader reader = File.OpenText(@"D:\Hello.txt"))
            {

                string s = "";
                while ((s = await reader.ReadLineAsync()) != null)
                {
                    Hellotxt += s + "\n";
                    //Console.WriteLine(s);
                }
            }
            return Hellotxt;
        }
        public async Task<string> WorldAsync()
        {
            string Worldtxt = null;
            using (StreamReader reader = File.OpenText(@"D:\World.txt"))
            {
                string s = "";
                while ((s = await reader.ReadLineAsync()) != null)
                {
                    Worldtxt += s + "\n";
                }
            }
            return Worldtxt;
        }
        public async Task<string> TwoMethods()
        {
            string Hellotxt = await Task.Run(() => HelloAsync());
            string Worldtxt = await Task.Run(() => WorldAsync());
            string[] HT = Hellotxt.Split("\n");
            string[] WT = Worldtxt.Split("\n");
            string result = null;
            foreach (var worlds in HT)
            {
                foreach (var other in WT)
                {
                    result += worlds + other;
                }
            }
            Console.WriteLine(result);
            return result;
        }
    }
}

