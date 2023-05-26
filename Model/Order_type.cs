using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_App.Model
{
    internal class Order_type
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Order_type()  {  }

        public Order_type(int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
