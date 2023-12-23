using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Storage
    {
        public List<Goods> storage = new List<Goods>();

        public void addGoods(Goods goods)
        {
            storage.Add(goods);
        }

        public void deleteGoods( Goods goods)
        {
            storage.Remove(goods);
        }

        public Goods findGoods(string name)
        {
            return storage.FirstOrDefault(g => g.nameGoods == name);
        }

        public void listGoods()
        {
            foreach (var goods in storage)
            {
                Console.WriteLine($"{goods.nameGoods} | {goods.descriptionGoods} | {goods.costGoods}");
            }
        }
    }
}
