using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_App.Model
{
    internal class OrderStatus
    {
        public int Id { get; set; }

        public string Status { get; set; }

        public OrderStatus(int id, string status)
        {
            Id = id;
            Status = status;
        }
        public OrderStatus()
        {
            
        }
    }
}
