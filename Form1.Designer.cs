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
            this.carOwnerCB = new System.Windows.Forms.ComboBox();
            this.carCB = new System.Windows.Forms.ComboBox();
            this.carOwnerL = new System.Windows.Forms.Label();
            this.carL = new System.Windows.Forms.Label();
            this.orderTypeL = new System.Windows.Forms.Label();
            this.orderTypeCB = new System.Windows.Forms.ComboBox();
            this.employeeL = new System.Windows.Forms.Label();
            this.employeeCB = new System.Windows.Forms.ComboBox();
            this.completeOrderBtn = new System.Windows.Forms.Button();
            this.newOrderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ordersPanel
            // 
            this.ordersPanel.AutoScroll = true;
            this.ordersPanel.Location = new System.Drawing.Point(13, 47);
            this.ordersPanel.Name = "ordersPanel";
            this.ordersPanel.Size = new System.Drawing.Size(864, 435);
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
            this.newOrderPanel.Controls.Add(this.completeOrderBtn);
            this.newOrderPanel.Controls.Add(this.employeeCB);
            this.newOrderPanel.Controls.Add(this.employeeL);
            this.newOrderPanel.Controls.Add(this.orderTypeCB);
            this.newOrderPanel.Controls.Add(this.orderTypeL);
            this.newOrderPanel.Controls.Add(this.carL);
            this.newOrderPanel.Controls.Add(this.carOwnerL);
            this.newOrderPanel.Controls.Add(this.carCB);
            this.newOrderPanel.Controls.Add(this.carOwnerCB);
            this.newOrderPanel.Location = new System.Drawing.Point(13, 47);
            this.newOrderPanel.Name = "newOrderPanel";
            this.newOrderPanel.Size = new System.Drawing.Size(864, 435);
            this.newOrderPanel.TabIndex = 1;
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
            // completeOrderBtn
            // 
            this.completeOrderBtn.Enabled = false;
            this.completeOrderBtn.Location = new System.Drawing.Point(3, 260);
            this.completeOrderBtn.Name = "completeOrderBtn";
            this.completeOrderBtn.Size = new System.Drawing.Size(115, 23);
            this.completeOrderBtn.TabIndex = 8;
            this.completeOrderBtn.Text = "Complete order";
            this.completeOrderBtn.UseVisualStyleBackColor = true;
            this.completeOrderBtn.Click += new System.EventHandler(this.completeOrderBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 494);
            this.Controls.Add(this.newOrderPanel);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.showOrdersBtn);
            this.Controls.Add(this.ordersPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.newOrderPanel.ResumeLayout(false);
            this.newOrderPanel.PerformLayout();
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
    }
}

