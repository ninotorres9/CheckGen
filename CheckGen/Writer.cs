using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace CheckGen
{
    public class Writer
    {
        private List<Item> list;
        private string fileName;

        public Writer(List<Item> list, string fileName)
        {
            this.list = list;
            this.fileName = fileName;
        }

        public void toFile()
        {
            // 赋值文件至桌面
            var sourcePath = "E:\\code\\CheckGen\\template.md";
            var targetPath = "E:\\temp\\result.md";
            if (File.Exists(targetPath))
                File.Delete(targetPath);
            File.Copy(sourcePath, targetPath);

            // 写入
            StreamWriter file = new System.IO.StreamWriter(targetPath, append: true);
            foreach (var item in list)
                file.WriteLine(item.toString());
            file.Close();

            // 打开
            System.Diagnostics.Process.Start(targetPath);

            //// 删除
            //Thread.Sleep(2000);
            //File.Delete(targetPath);

        }
    }
}
