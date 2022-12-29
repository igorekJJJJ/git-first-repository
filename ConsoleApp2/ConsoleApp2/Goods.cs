using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Goods
    {
        public string nameGoods { get; set; }
        public string descriptionGoods { get; set; }
        public double costGoods { get; set; }

        public Goods(string name, string descr, double cost)
        {
            nameGoods = name;
            descriptionGoods = descr;
            costGoods = cost;
        }

        public Goods(){}

        public List<Goods> storage = new List<Goods>();
    }
}
