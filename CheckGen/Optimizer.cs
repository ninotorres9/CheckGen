using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckGen
{
    public class Optimizer
    {
        private List<Item> itemList;
        public List<Item> ItemList { get => itemList; set => itemList = value; }

        public Optimizer(List<Item> itemList)
        {
            this.ItemList = itemList;
            optimize();
        }
        public void optimize()
        {
            // ItemList.Remove(ItemList.Single(s => s.IsPassed == true));
            ItemList.RemoveAll(i => i.IsPassed == true);
        }
        public List<Item> getResult()
        {
            return ItemList;   
        }
    }
}
