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

namespace Workshop_App
{
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
        }

        int orderId = 0;

        public OrderControl(string carName, string ownerName, string ownerPhone, string employeeName, string employeeSpecialization, int price, DateTime dateTime,
            string status, string orderType, int orderId) : this()
        {
            string date = dateTime.ToString();
            date = date.Substring(0, date.Length - 9);

            carL.Text = carName;
            ownerNameL.Text = ownerName;
            ownerPhoneL.Text = ownerPhone;
            employeeL.Text = $"{employeeName} ({employeeSpecialization})";
            priceL.Text = $"{price} $";
            orderDateL.Text = date;
            statusL.Text = status;
            orderTypeL.Text = orderType;
            this.orderId = orderId;

            if(status.Equals("Done"))
            {
                doneOrderBtn.Enabled = false;
                doneOrderBtn.Visible = false;
            }
        }

        private void OrderControl_Load(object sender, EventArgs e)
        {

        }

        private void doneOrderBtn_Click(object sender, EventArgs e)
        {
            DBController dBController = new DBController();
            if (orderId != 0)
            {
                dBController.ChangeOrderStatus("Done", orderId);
                statusL.Text = "Done";

                doneOrderBtn.Enabled = false;
                doneOrderBtn.Visible = false;
            }
        }
    }
}
