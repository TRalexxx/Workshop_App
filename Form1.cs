﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop_App.Controller;
using Workshop_App.Model;

namespace Workshop_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showOrdersBtn_Click(object sender, EventArgs e)
        {
            ordersPanel.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ordersPanel.Visible = false;
            List<Orders> orders = dBController.GetOrders();
            List<Car> cars = dBController.GetCars();
            List<Car_owner> carOwners = dBController.GetCars_owner();
            List<Employe> employes = dBController.GetEmployes();
            List<EmployeeSpecialization> employeeSpecializations = dBController.GetEmployeeSpecializations();
            List<Specializations> specializations = dBController.GetSpecializations();
            List<Order_type> orderTypes = dBController.GetOrderTypes();
            List<OrderStatus> orderStatuses = dBController.GetOrderStatus();

            int x = 5;
            int y = 5;

            for (int i = 0;i<orders.Count; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < employeeSpecializations.Count; j++)
                {
                    if (orders[i].Employee_Id.Equals(employeeSpecializations[j].Employee_Id))
                    {
                        sb.Append($"{specializations[employeeSpecializations[j].Specialization_Id-1].Name} ");
                    }
                }
                if(sb.Length > 0) sb.Length -= 1;
                
                OrderControl orderControl = new OrderControl(cars[orders[i].Car_Id-1].Name, carOwners[cars[orders[i].Car_Id - 1].Owner_id-1].Name,
                    carOwners[cars[orders[i].Car_Id - 1].Owner_id-1].Phone_number, employes[orders[i].Employee_Id-1].Name, sb.ToString(),
                    orderTypes.FirstOrDefault(ord => ord.Id.Equals(orders[i].Order_Id)).Price, orders[i].Order_Date, orderStatuses[orders[i].OrderStatus_Id].Status);
                orderControl.Location = new Point(x, y);
                ordersPanel.Controls.Add(orderControl);

                y += orderControl.Height + 5;

            }
        }

        DBController dBController = new DBController();
    }
}
