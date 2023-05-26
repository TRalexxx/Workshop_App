using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_App.Model
{
    internal class Specializations
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Specializations()  { }

        public Specializations(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
