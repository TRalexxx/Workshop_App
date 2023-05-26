using System;
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
            newOrderPanel.Visible = false;
            newClientPanel.Visible = false;
            ordersPanel.Visible = true;

            
            orders = dBController.GetOrders();
            cars = dBController.GetCars();
            carOwners = dBController.GetCars_owner();
            employes = dBController.GetEmployes();
            employeeSpecializations = dBController.GetEmployeeSpecializations();
            specializations = dBController.GetSpecializations();
            orderTypes = dBController.GetOrderTypes();
            orderStatuses = dBController.GetOrderStatus();

            int x = 5;
            int y = 5;

            for (int i = 0; i < orders.Count; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < employeeSpecializations.Count; j++)
                {
                    if (orders[i].Employee_Id.Equals(employeeSpecializations[j].Employee_Id))
                    {
                        sb.Append($"{specializations[employeeSpecializations[j].Specialization_Id - 1].Name} ");
                    }
                }
                if (sb.Length > 0) sb.Length -= 1;

                OrderControl orderControl = new OrderControl(cars[orders[i].Car_Id - 1].Name, carOwners[cars[orders[i].Car_Id - 1].Owner_id - 1].Name,
                    carOwners[cars[orders[i].Car_Id - 1].Owner_id - 1].Phone_number, employes[orders[i].Employee_Id - 1].Name, sb.ToString(),
                    orderTypes.FirstOrDefault(ord => ord.Id.Equals(orders[i].Order_Id)).Price, orders[i].Order_Date, orderStatuses[orders[i].OrderStatus_Id].Status);
                orderControl.Location = new Point(x, y);
                ordersPanel.Controls.Add(orderControl);

                y += orderControl.Height + 5;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            ordersPanel.Visible = false;
            newOrderPanel.Visible = false;
            newClientPanel.Visible = false;

        }

        DBController dBController = new DBController();

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            ordersPanel.Visible = false;
            newOrderPanel.Visible = true;
            newClientPanel.Visible = false;
            
            carOwners = dBController.GetCars_owner();
            
            

            for (int i = 0; i < carOwners.Count; i++)
            {
                carOwnerCB.Items.Add(carOwners[i].Name);
            }

           



        }

        private void carOwnerCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            cars = dBController.GetCars();

            carCB.Items.Clear();

            for (int i = 0; i < cars.Count; i++)
            {
                if (carOwnerCB.SelectedIndex.Equals(cars[i].Owner_id-1))
                {
                    carCB.Items.Add(cars[i].Name);
                }
            }
            carCB.Enabled = true;
        }

        List<Orders> orders;
        List<Car> cars;
        List<Car_owner> carOwners;
        List<Employe> employes;
        List<EmployeeSpecialization> employeeSpecializations;
        List<Specializations> specializations;
        List<Order_type> orderTypes;
        List<OrderStatus> orderStatuses;

        private void carCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            orderTypes = dBController.GetOrderTypes();

            for(int i = 0;i < orderTypes.Count;i++)
            {
                orderTypeCB.Items.Add(orderTypes[i].Name);
            }

            orderTypeCB.Enabled = true;
        }

        private void orderTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            employes = dBController.GetEmployes();

            for(int i = 0; i < employes.Count;i++)
            {
                employeeCB.Items.Add(employes[i].Name);
            }

            employeeCB.Enabled = true;
        }

        private void completeOrderBtn_Click(object sender, EventArgs e)
        {

            string date = DateTime.Now.ToString("yyyy-MM-dd");
            

            if(dBController.AddNewOrder(carCB.SelectedIndex+1, employeeCB.SelectedIndex+1, orderTypeCB.SelectedIndex+1, date))
            {
                MessageBox.Show("New order added!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information );
                carCB.Enabled = false;
                orderTypeCB.Enabled=false;
                employeeCB.Enabled=false;
                completeOrderBtn.Enabled=false;
            }
            else
            {
                MessageBox.Show("Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void employeeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            completeOrderBtn.Enabled = true;
        }

        private void addNewClientBtn_Click(object sender, EventArgs e)
        {
            if(clientNameTB.Text.Equals("")||clientPhoneNumberTB.Text.Equals("")||carNameTB.Text.Equals(""))
            {
                MessageBox.Show("Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dBController.AddNewClient(clientNameTB.Text, clientPhoneNumberTB.Text, carNameTB.Text);
                MessageBox.Show("New client added!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void newClientBtn_Click(object sender, EventArgs e)
        {
            newClientPanel.Visible = true;
            newOrderPanel.Visible = false;
            ordersPanel.Visible = false;
        }
    }
}
