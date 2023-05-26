using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop_App
{
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
        }

        public OrderControl(string carName, string ownerName, string ownerPhone, string employeeName, string employeeSpecialization, int price, DateTime dateTime,
            string status) : this()
        {
            carL.Text = carName;
            ownerNameL.Text = ownerName;
            ownerPhoneL.Text = ownerPhone;
            employeeL.Text = $"{employeeName} ({employeeSpecialization})";
            priceL.Text = price.ToString();
            orderDateL.Text = dateTime.ToString();
            statusL.Text = status.ToString();
        }

        private void OrderControl_Load(object sender, EventArgs e)
        {

        }
    }
}
