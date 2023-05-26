using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop_App.Model;

namespace Workshop_App.Controller
{
    internal class DBController
    {
        public string StrConn { get; set; }
        public DBController() 
        {
            StrConn = "Server=DESKTOP-O6O2RKO;" +
                    "Database=Workshop_db;" +
                    "Trusted_Connection=True;" +
                    "TrustServerCertificate=True;";
        }

        public DBController(string strConn)
        {
            StrConn = strConn;
        }

        public List<Car> GetCars()
        {
            using(SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();

                List<Car> cars = (List<Car>)conn.Query<Car>("SELECT * FROM [Car];");
                
                return cars;
            }
        }

        public List<Car_owner> GetCars_owner()
        {
            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();

                List<Car_owner> car_owners = (List<Car_owner>)conn.Query<Car_owner>("SELECT * FROM [Car_owner];");

                return car_owners;
            }
        }

        public List<Employe> GetEmployes()
        {
            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();

                List<Employe> employees = (List<Employe>)conn.Query<Employe>("SELECT * FROM [Employe]");

                return employees;
            }
        }

        public List<Specializations> GetSpecializations()
        {
            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();

                List<Specializations> specializations = (List<Specializations>)conn.Query<Specializations>("SELECT * FROM [Specializations]");

                return specializations;
            }
        }

        public List<EmployeeSpecialization> GetEmployeeSpecializations()
        {
            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();

                List<EmployeeSpecialization> employeeSpecializations = (List<EmployeeSpecialization>)conn.Query<EmployeeSpecialization>("SELECT * FROM [EmployeeSpecialization]");

                return employeeSpecializations;
            }
        }

        public List<Order_type> GetOrderTypes()
        {
            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();

                List<Order_type> orders = (List<Order_type>)conn.Query<Order_type>("SELECT * FROM [Order_type];");

                return orders;
            }
        }

        public List<OrderStatus> GetOrderStatus()
        {
            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();

                List<OrderStatus> orderStatus = (List<OrderStatus>)conn.Query<OrderStatus>("SELECT * FROM [Order_status];");

                return orderStatus;
            }
        }

        public List<Orders> GetOrders()
        {
            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();

                List<Orders> orders = (List<Orders>)conn.Query<Orders>("SELECT * FROM [Orders];");

                return orders;
            }
        }

        public bool AddNewOrder(int carId, int employeeId, int orderId, string currDate)
        {
            using(SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();

                int rez = conn.Execute($"INSERT INTO [Orders](car_id, employee_id, order_id, order_date, order_status_id) VALUES({carId}, {employeeId}, {orderId}, '{currDate}', 1)");

                if (rez > 0) { return true; }
                else { return false; }
            }
        }

        public void AddNewClient(string carOwnerName, string carOwnerPhoneNumber, string carName)
        {
            using(SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();

                var carOwners = conn.Query<Car_owner>("SELECT * FROM [Car_owner]");
                int id = carOwners.Last().Id;

                int rez = conn.Execute($"INSERT INTO [Car_owner](name, phone_number) VALUES('{carOwnerName}', '{carOwnerPhoneNumber}')");

                int rez2 = conn.Execute($"INSERT INTO [Car](name, owner_id) VALUES('{carName}', {++id})");
            }
        }
    }
}
