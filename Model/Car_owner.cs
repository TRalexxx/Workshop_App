using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_App.Model
{
    internal class Car_owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone_number { get; set; }
        public Car_owner() { }

        public Car_owner(int id, string name, string phone_number)
        {
            Id = id;
            Name = name;
            Phone_number = phone_number;
        }
    }
}
