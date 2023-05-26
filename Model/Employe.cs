using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_App.Model
{
    internal class Employe
    {
        public int Id { get; set; }
        public string Name { get; set; }        

        public Employe() {
            
        }

        public Employe(int id, string name) 
        { 
            Id = id; 
            Name = name;            
        }
    }

}
