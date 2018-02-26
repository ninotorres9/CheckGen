using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToExcel;

namespace CheckGen
{
    public class Reader
    {
        private ExcelQueryFactory excel;
        private List<Item> itemList = null;
        public Reader(string filename)
        {
            this.excel = new ExcelQueryFactory(filename);
            this.itemList = new List<Item>();

            // 将excel转换为itemList
            foreach(var sheetName in excel.GetWorksheetNames())
            {
                foreach (var row in getRows(sheetName))
                {
                    itemList.Add(toItem(row));
                }
            }
        }
        
        private RowNoHeader[] getRows(string sheetName)
        {            
            // 剔除标题行
            int space = 3;
            string flag = "状态";

            var rowsQueryTable = from r in this.excel.WorksheetNoHeader(sheetName) //("分类")
                                 where r[space] != "" && r[space] != flag
                                 select r;

            return rowsQueryTable.ToArray();
        }
        private Item toItem(RowNoHeader row)
        {
            var type = row[1].ToString();
            var content = row[2].ToString();
            var isPassed = row[3] != "-" ? true : false;
            var comment = row[4].ToString();

            return new Item(type, content, isPassed, comment);

        }
        public List<Item> getResult()
        {
            return itemList;
        }
        static public bool isDigit(string text)
        {
            foreach (var t in text)
            {
                if (!char.IsDigit(t)) return false;
            }
            return true;
        }
    }
}
