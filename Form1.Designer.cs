namespace Workshop_App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ordersPanel = new System.Windows.Forms.Panel();
            this.showOrdersBtn = new System.Windows.Forms.Button();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.newOrderPanel = new System.Windows.Forms.Panel();
            this.completeOrderBtn = new System.Windows.Forms.Button();
            this.employeeCB = new System.Windows.Forms.ComboBox();
            this.employeeL = new System.Windows.Forms.Label();
            this.orderTypeCB = new System.Windows.Forms.ComboBox();
            this.orderTypeL = new System.Windows.Forms.Label();
            this.carL = new System.Windows.Forms.Label();
            this.carOwnerL = new System.Windows.Forms.Label();
            this.carCB = new System.Windows.Forms.ComboBox();
            this.carOwnerCB = new System.Windows.Forms.ComboBox();
            this.newClientPanel = new System.Windows.Forms.Panel();
            this.clientPhoneNumberTB = new System.Windows.Forms.TextBox();
            this.clintPhNumL = new System.Windows.Forms.Label();
            this.addNewClientBtn = new System.Windows.Forms.Button();
            this.carNameTB = new System.Windows.Forms.TextBox();
            this.carNameL = new System.Windows.Forms.Label();
            this.clientNameL = new System.Windows.Forms.Label();
            this.clientNameTB = new System.Windows.Forms.TextBox();
            this.newClientBtn = new System.Windows.Forms.Button();
            this.newEmployeeBtn = new System.Windows.Forms.Button();
            this.newEmployeePanel = new System.Windows.Forms.Panel();
            this.confirmNewEmployeeBtn = new System.Windows.Forms.Button();
            this.choosedSpecsL = new System.Windows.Forms.Label();
            this.addSpecializationBtn = new System.Windows.Forms.Button();
            this.chooseSpecializationsCB = new System.Windows.Forms.ComboBox();
            this.chooseSpecsL = new System.Windows.Forms.Label();
            this.employeeNameTB = new System.Windows.Forms.TextBox();
            this.newEmployeeNameL = new System.Windows.Forms.Label();
            this.odrerDatePicker = new System.Windows.Forms.DateTimePicker();
            this.newOrderPanel.SuspendLayout();
            this.newClientPanel.SuspendLayout();
            this.newEmployeePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ordersPanel
            // 
            this.ordersPanel.AutoScroll = true;
            this.ordersPanel.Location = new System.Drawing.Point(12, 47);
            this.ordersPanel.Name = "ordersPanel";
            this.ordersPanel.Size = new System.Drawing.Size(588, 435);
            this.ordersPanel.TabIndex = 0;
            this.ordersPanel.Visible = false;
            // 
            // showOrdersBtn
            // 
            this.showOrdersBtn.Location = new System.Drawing.Point(13, 13);
            this.showOrdersBtn.Name = "showOrdersBtn";
            this.showOrdersBtn.Size = new System.Drawing.Size(105, 23);
            this.showOrdersBtn.TabIndex = 1;
            this.showOrdersBtn.Text = "Show Orders";
            this.showOrdersBtn.UseVisualStyleBackColor = true;
            this.showOrdersBtn.Click += new System.EventHandler(this.showOrdersBtn_Click);
            // 
            // newOrderButton
            // 
            this.newOrderButton.Location = new System.Drawing.Point(124, 13);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(105, 23);
            this.newOrderButton.TabIndex = 2;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // newOrderPanel
            // 
            this.newOrderPanel.AutoScroll = true;
            this.newOrderPanel.Controls.Add(this.odrerDatePicker);
            this.newOrderPanel.Controls.Add(this.completeOrderBtn);
            this.newOrderPanel.Controls.Add(this.employeeCB);
            this.newOrderPanel.Controls.Add(this.employeeL);
            this.newOrderPanel.Controls.Add(this.orderTypeCB);
            this.newOrderPanel.Controls.Add(this.orderTypeL);
            this.newOrderPanel.Controls.Add(this.carL);
            this.newOrderPanel.Controls.Add(this.carOwnerL);
            this.newOrderPanel.Controls.Add(this.carCB);
            this.newOrderPanel.Controls.Add(this.carOwnerCB);
            this.newOrderPanel.Location = new System.Drawing.Point(9, 47);
            this.newOrderPanel.Name = "newOrderPanel";
            this.newOrderPanel.Size = new System.Drawing.Size(585, 432);
            this.newOrderPanel.TabIndex = 1;
            // 
            // completeOrderBtn
            // 
            this.completeOrderBtn.Enabled = false;
            this.completeOrderBtn.Location = new System.Drawing.Point(3, 263);
            this.completeOrderBtn.Name = "completeOrderBtn";
            this.completeOrderBtn.Size = new System.Drawing.Size(115, 23);
            this.completeOrderBtn.TabIndex = 8;
            this.completeOrderBtn.Text = "Complete order";
            this.completeOrderBtn.UseVisualStyleBackColor = true;
            this.completeOrderBtn.Click += new System.EventHandler(this.completeOrderBtn_Click);
            // 
            // employeeCB
            // 
            this.employeeCB.Enabled = false;
            this.employeeCB.FormattingEnabled = true;
            this.employeeCB.Location = new System.Drawing.Point(3, 179);
            this.employeeCB.Name = "employeeCB";
            this.employeeCB.Size = new System.Drawing.Size(378, 21);
            this.employeeCB.TabIndex = 7;
            this.employeeCB.SelectedIndexChanged += new System.EventHandler(this.employeeCB_SelectedIndexChanged);
            // 
            // employeeL
            // 
            this.employeeL.AutoSize = true;
            this.employeeL.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeL.Location = new System.Drawing.Point(3, 153);
            this.employeeL.Name = "employeeL";
            this.employeeL.Size = new System.Drawing.Size(84, 23);
            this.employeeL.TabIndex = 6;
            this.employeeL.Text = "Employee";
            // 
            // orderTypeCB
            // 
            this.orderTypeCB.Enabled = false;
            this.orderTypeCB.FormattingEnabled = true;
            this.orderTypeCB.Location = new System.Drawing.Point(3, 129);
            this.orderTypeCB.Name = "orderTypeCB";
            this.orderTypeCB.Size = new System.Drawing.Size(378, 21);
            this.orderTypeCB.TabIndex = 5;
            this.orderTypeCB.SelectedIndexChanged += new System.EventHandler(this.orderTypeCB_SelectedIndexChanged);
            // 
            // orderTypeL
            // 
            this.orderTypeL.AutoSize = true;
            this.orderTypeL.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderTypeL.Location = new System.Drawing.Point(3, 103);
            this.orderTypeL.Name = "orderTypeL";
            this.orderTypeL.Size = new System.Drawing.Size(91, 23);
            this.orderTypeL.TabIndex = 4;
            this.orderTypeL.Text = "Order type";
            // 
            // carL
            // 
            this.carL.AutoSize = true;
            this.carL.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carL.Location = new System.Drawing.Point(3, 53);
            this.carL.Name = "carL";
            this.carL.Size = new System.Drawing.Size(36, 23);
            this.carL.TabIndex = 3;
            this.carL.Text = "Car";
            // 
            // carOwnerL
            // 
            this.carOwnerL.AutoSize = true;
            this.carOwnerL.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carOwnerL.Location = new System.Drawing.Point(3, 3);
            this.carOwnerL.Name = "carOwnerL";
            this.carOwnerL.Size = new System.Drawing.Size(90, 23);
            this.carOwnerL.TabIndex = 2;
            this.carOwnerL.Text = "Car owner";
            // 
            // carCB
            // 
            this.carCB.Enabled = false;
            this.carCB.FormattingEnabled = true;
            this.carCB.Location = new System.Drawing.Point(3, 79);
            this.carCB.Name = "carCB";
            this.carCB.Size = new System.Drawing.Size(378, 21);
            this.carCB.TabIndex = 1;
            this.carCB.SelectedIndexChanged += new System.EventHandler(this.carCB_SelectedIndexChanged);
            // 
            // carOwnerCB
            // 
            this.carOwnerCB.FormattingEnabled = true;
            this.carOwnerCB.Location = new System.Drawing.Point(3, 29);
            this.carOwnerCB.Name = "carOwnerCB";
            this.carOwnerCB.Size = new System.Drawing.Size(378, 21);
            this.carOwnerCB.TabIndex = 0;
            this.carOwnerCB.SelectedIndexChanged += new System.EventHandler(this.carOwnerCB_SelectedIndexChanged);
            // 
            // newClientPanel
            // 
            this.newClientPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.newClientPanel.Controls.Add(this.clientPhoneNumberTB);
            this.newClientPanel.Controls.Add(this.clintPhNumL);
            this.newClientPanel.Controls.Add(this.addNewClientBtn);
            this.newClientPanel.Controls.Add(this.carNameTB);
            this.newClientPanel.Controls.Add(this.carNameL);
            this.newClientPanel.Controls.Add(this.clientNameL);
            this.newClientPanel.Controls.Add(this.clientNameTB);
            this.newClientPanel.Location = new System.Drawing.Point(12, 47);
            this.newClientPanel.Name = "newClientPanel";
            this.newClientPanel.Size = new System.Drawing.Size(582, 439);
            this.newClientPanel.TabIndex = 1;
            this.newClientPanel.Visible = false;
            // 
            // clientPhoneNumberTB
            // 
            this.clientPhoneNumberTB.Location = new System.Drawing.Point(7, 96);
            this.clientPhoneNumberTB.Name = "clientPhoneNumberTB";
            this.clientPhoneNumberTB.Size = new System.Drawing.Size(374, 20);
            this.clientPhoneNumberTB.TabIndex = 7;
            // 
            // clintPhNumL
            // 
            this.clintPhNumL.AutoSize = true;
            this.clintPhNumL.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clintPhNumL.Location = new System.Drawing.Point(7, 74);
            this.clintPhNumL.Name = "clintPhNumL";
            this.clintPhNumL.Size = new System.Drawing.Size(204, 19);
            this.clintPhNumL.TabIndex = 6;
            this.clintPhNumL.Text = "Enter client phone number";
            // 
            // addNewClientBtn
            // 
            this.addNewClientBtn.Location = new System.Drawing.Point(7, 193);
            this.addNewClientBtn.Name = "addNewClientBtn";
            this.addNewClientBtn.Size = new System.Drawing.Size(98, 23);
            this.addNewClientBtn.TabIndex = 5;
            this.addNewClientBtn.Text = "Add new client";
            this.addNewClientBtn.UseVisualStyleBackColor = true;
            this.addNewClientBtn.Click += new System.EventHandler(this.addNewClientBtn_Click);
            // 
            // carNameTB
            // 
            this.carNameTB.Location = new System.Drawing.Point(7, 157);
            this.carNameTB.Name = "carNameTB";
            this.carNameTB.Size = new System.Drawing.Size(374, 20);
            this.carNameTB.TabIndex = 4;
            // 
            // carNameL
            // 
            this.carNameL.AutoSize = true;
            this.carNameL.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carNameL.Location = new System.Drawing.Point(7, 130);
            this.carNameL.Name = "carNameL";
            this.carNameL.Size = new System.Drawing.Size(123, 19);
            this.carNameL.TabIndex = 3;
            this.carNameL.Text = "Enter car name";
            // 
            // clientNameL
            // 
            this.clientNameL.AutoSize = true;
            this.clientNameL.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientNameL.Location = new System.Drawing.Point(7, 8);
            this.clientNameL.Name = "clientNameL";
            this.clientNameL.Size = new System.Drawing.Size(138, 19);
            this.clientNameL.TabIndex = 1;
            this.clientNameL.Text = "Enter client name";
            // 
            // clientNameTB
            // 
            this.clientNameTB.Location = new System.Drawing.Point(7, 34);
            this.clientNameTB.Name = "clientNameTB";
            this.clientNameTB.Size = new System.Drawing.Size(374, 20);
            this.clientNameTB.TabIndex = 0;
            // 
            // newClientBtn
            // 
            this.newClientBtn.Location = new System.Drawing.Point(235, 12);
            this.newClientBtn.Name = "newClientBtn";
            this.newClientBtn.Size = new System.Drawing.Size(105, 23);
            this.newClientBtn.TabIndex = 3;
            this.newClientBtn.Text = "New Client";
            this.newClientBtn.UseVisualStyleBackColor = true;
            this.newClientBtn.Click += new System.EventHandler(this.newClientBtn_Click);
            // 
            // newEmployeeBtn
            // 
            this.newEmployeeBtn.Location = new System.Drawing.Point(346, 12);
            this.newEmployeeBtn.Name = "newEmployeeBtn";
            this.newEmployeeBtn.Size = new System.Drawing.Size(105, 23);
            this.newEmployeeBtn.TabIndex = 4;
            this.newEmployeeBtn.Text = "New Employee";
            this.newEmployeeBtn.UseVisualStyleBackColor = true;
            this.newEmployeeBtn.Click += new System.EventHandler(this.newEmployeeBtn_Click);
            // 
            // newEmployeePanel
            // 
            this.newEmployeePanel.BackColor = System.Drawing.Color.Gainsboro;
            this.newEmployeePanel.Controls.Add(this.confirmNewEmployeeBtn);
            this.newEmployeePanel.Controls.Add(this.choosedSpecsL);
            this.newEmployeePanel.Controls.Add(this.addSpecializationBtn);
            this.newEmployeePanel.Controls.Add(this.chooseSpecializationsCB);
            this.newEmployeePanel.Controls.Add(this.chooseSpecsL);
            this.newEmployeePanel.Controls.Add(this.employeeNameTB);
            this.newEmployeePanel.Controls.Add(this.newEmployeeNameL);
            this.newEmployeePanel.Location = new System.Drawing.Point(12, 47);
            this.newEmployeePanel.Name = "newEmployeePanel";
            this.newEmployeePanel.Size = new System.Drawing.Size(585, 439);
            this.newEmployeePanel.TabIndex = 8;
            // 
            // confirmNewEmployeeBtn
            // 
            this.confirmNewEmployeeBtn.Location = new System.Drawing.Point(14, 183);
            this.confirmNewEmployeeBtn.Name = "confirmNewEmployeeBtn";
            this.confirmNewEmployeeBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmNewEmployeeBtn.TabIndex = 6;
            this.confirmNewEmployeeBtn.Text = "Confirm";
            this.confirmNewEmployeeBtn.UseVisualStyleBackColor = true;
            this.confirmNewEmployeeBtn.Click += new System.EventHandler(this.confirmNewEmployeeBtn_Click);
            // 
            // choosedSpecsL
            // 
            this.choosedSpecsL.AutoSize = true;
            this.choosedSpecsL.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosedSpecsL.Location = new System.Drawing.Point(14, 130);
            this.choosedSpecsL.Name = "choosedSpecsL";
            this.choosedSpecsL.Size = new System.Drawing.Size(0, 29);
            this.choosedSpecsL.TabIndex = 5;
            // 
            // addSpecializationBtn
            // 
            this.addSpecializationBtn.Location = new System.Drawing.Point(388, 96);
            this.addSpecializationBtn.Name = "addSpecializationBtn";
            this.addSpecializationBtn.Size = new System.Drawing.Size(50, 23);
            this.addSpecializationBtn.TabIndex = 4;
            this.addSpecializationBtn.Text = "Add";
            this.addSpecializationBtn.UseVisualStyleBackColor = true;
            this.addSpecializationBtn.Click += new System.EventHandler(this.addSpecializationBtn_Click);
            // 
            // chooseSpecializationsCB
            // 
            this.chooseSpecializationsCB.FormattingEnabled = true;
            this.chooseSpecializationsCB.Location = new System.Drawing.Point(14, 96);
            this.chooseSpecializationsCB.Name = "chooseSpecializationsCB";
            this.chooseSpecializationsCB.Size = new System.Drawing.Size(367, 21);
            this.chooseSpecializationsCB.TabIndex = 3;
            // 
            // chooseSpecsL
            // 
            this.chooseSpecsL.AutoSize = true;
            this.chooseSpecsL.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseSpecsL.Location = new System.Drawing.Point(11, 74);
            this.chooseSpecsL.Name = "chooseSpecsL";
            this.chooseSpecsL.Size = new System.Drawing.Size(295, 18);
            this.chooseSpecsL.TabIndex = 2;
            this.chooseSpecsL.Text = "Choose employee specialization(s)";
            // 
            // employeeNameTB
            // 
            this.employeeNameTB.Location = new System.Drawing.Point(14, 30);
            this.employeeNameTB.Name = "employeeNameTB";
            this.employeeNameTB.Size = new System.Drawing.Size(367, 20);
            this.employeeNameTB.TabIndex = 1;
            // 
            // newEmployeeNameL
            // 
            this.newEmployeeNameL.AutoSize = true;
            this.newEmployeeNameL.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newEmployeeNameL.Location = new System.Drawing.Point(11, 8);
            this.newEmployeeNameL.Name = "newEmployeeNameL";
            this.newEmployeeNameL.Size = new System.Drawing.Size(200, 18);
            this.newEmployeeNameL.TabIndex = 0;
            this.newEmployeeNameL.Text = "Enter employee\'s name";
            // 
            // odrerDatePicker
            // 
            this.odrerDatePicker.Location = new System.Drawing.Point(0, 209);
            this.odrerDatePicker.Name = "odrerDatePicker";
            this.odrerDatePicker.Size = new System.Drawing.Size(200, 20);
            this.odrerDatePicker.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 498);
            this.Controls.Add(this.newClientPanel);
            this.Controls.Add(this.newEmployeePanel);
            this.Controls.Add(this.newOrderPanel);
            this.Controls.Add(this.newEmployeeBtn);
            this.Controls.Add(this.newClientBtn);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.showOrdersBtn);
            this.Controls.Add(this.ordersPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.newOrderPanel.ResumeLayout(false);
            this.newOrderPanel.PerformLayout();
            this.newClientPanel.ResumeLayout(false);
            this.newClientPanel.PerformLayout();
            this.newEmployeePanel.ResumeLayout(false);
            this.newEmployeePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ordersPanel;
        private System.Windows.Forms.Button showOrdersBtn;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Panel newOrderPanel;
        private System.Windows.Forms.Button completeOrderBtn;
        private System.Windows.Forms.ComboBox employeeCB;
        private System.Windows.Forms.Label employeeL;
        private System.Windows.Forms.ComboBox orderTypeCB;
        private System.Windows.Forms.Label orderTypeL;
        private System.Windows.Forms.Label carL;
        private System.Windows.Forms.Label carOwnerL;
        private System.Windows.Forms.ComboBox carCB;
        private System.Windows.Forms.ComboBox carOwnerCB;
        private System.Windows.Forms.Panel newClientPanel;
        private System.Windows.Forms.TextBox clientPhoneNumberTB;
        private System.Windows.Forms.Label clintPhNumL;
        private System.Windows.Forms.Button addNewClientBtn;
        private System.Windows.Forms.TextBox carNameTB;
        private System.Windows.Forms.Label carNameL;
        private System.Windows.Forms.Label clientNameL;
        private System.Windows.Forms.TextBox clientNameTB;
        private System.Windows.Forms.Button newClientBtn;
        private System.Windows.Forms.Panel newEmployeePanel;
        private System.Windows.Forms.Button confirmNewEmployeeBtn;
        private System.Windows.Forms.Label choosedSpecsL;
        private System.Windows.Forms.Button addSpecializationBtn;
        private System.Windows.Forms.ComboBox chooseSpecializationsCB;
        private System.Windows.Forms.Label chooseSpecsL;
        private System.Windows.Forms.TextBox employeeNameTB;
        private System.Windows.Forms.Label newEmployeeNameL;
        private System.Windows.Forms.Button newEmployeeBtn;
        private System.Windows.Forms.DateTimePicker odrerDatePicker;
    }
}

