using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToExcel;
using System.IO;

using Excel = Microsoft.Office.Interop.Excel;

using RazorEngine;
using RazorEngine.Templating;

namespace CheckGen
{
    class Program
    {
        public class UserInfo
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        static void Main(string[] args)
        {
            if(args.Count() > 0)
            {
                string filename = args[0]; 
                Reader reader = new Reader(filename);
                Optimizer optimizer = new Optimizer(reader.getResult());
                Writer writer = new Writer(optimizer.getResult(), "123");
                writer.toFile();
            }
            else
            {
                Console.WriteLine("请输入文件路径");
            }

        }
    }
}
