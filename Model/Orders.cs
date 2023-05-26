using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_App.Model
{
    internal class Orders
    {
        public int Id { get; set; }
        public int Car_Id { get; set; }
        public int Employee_Id { get; set; }
        public int Order_Id { get; set; }
        public int Order_Status_Id { get; set; }
        public DateTime Order_Date { get; set; }

        public Orders()  {  }

        public Orders(int id, int carId, int employeeId, int orderId, int orderStatusId, DateTime orderDate)
        {
            Id = id;
            Car_Id = carId;
            Employee_Id = employeeId;
            Order_Id = orderId;
            Order_Status_Id = orderStatusId;
            Order_Date = orderDate;
        }
    }
}
