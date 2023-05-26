using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_App.Model
{
    internal class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Owner_id { get; set; }

        public Car() { }

        public Car(int id, string name, int owner_id)
        {
            Id = id;
            Name = name;
            Owner_id = owner_id;
        }
    }
}
