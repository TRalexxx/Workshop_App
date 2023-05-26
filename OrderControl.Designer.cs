namespace Workshop_App
{
    partial class OrderControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.carL = new System.Windows.Forms.Label();
            this.ownerNameL = new System.Windows.Forms.Label();
            this.ownerPhoneL = new System.Windows.Forms.Label();
            this.employeeL = new System.Windows.Forms.Label();
            this.priceL = new System.Windows.Forms.Label();
            this.orderDateL = new System.Windows.Forms.Label();
            this.statusL = new System.Windows.Forms.Label();
            this.orderTypeL = new System.Windows.Forms.Label();
            this.doneOrderBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // carL
            // 
            this.carL.AutoSize = true;
            this.carL.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carL.Location = new System.Drawing.Point(4, 4);
            this.carL.Name = "carL";
            this.carL.Size = new System.Drawing.Size(50, 23);
            this.carL.TabIndex = 0;
            this.carL.Text = "carL";
            // 
            // ownerNameL
            // 
            this.ownerNameL.AutoSize = true;
            this.ownerNameL.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ownerNameL.Location = new System.Drawing.Point(5, 27);
            this.ownerNameL.Name = "ownerNameL";
            this.ownerNameL.Size = new System.Drawing.Size(90, 17);
            this.ownerNameL.TabIndex = 1;
            this.ownerNameL.Text = "ownerNameL";
            // 
            // ownerPhoneL
            // 
            this.ownerPhoneL.AutoSize = true;
            this.ownerPhoneL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ownerPhoneL.Location = new System.Drawing.Point(5, 44);
            this.ownerPhoneL.Name = "ownerPhoneL";
            this.ownerPhoneL.Size = new System.Drawing.Size(89, 16);
            this.ownerPhoneL.TabIndex = 2;
            this.ownerPhoneL.Text = "ownerPhoneL";
            // 
            // employeeL
            // 
            this.employeeL.AutoSize = true;
            this.employeeL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeL.Location = new System.Drawing.Point(4, 100);
            this.employeeL.Name = "employeeL";
            this.employeeL.Size = new System.Drawing.Size(77, 19);
            this.employeeL.TabIndex = 3;
            this.employeeL.Text = "employee";
            // 
            // priceL
            // 
            this.priceL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priceL.AutoSize = true;
            this.priceL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceL.Location = new System.Drawing.Point(445, 6);
            this.priceL.Name = "priceL";
            this.priceL.Size = new System.Drawing.Size(51, 22);
            this.priceL.TabIndex = 4;
            this.priceL.Text = "price";
            // 
            // orderDateL
            // 
            this.orderDateL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.orderDateL.AutoSize = true;
            this.orderDateL.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderDateL.Location = new System.Drawing.Point(435, 45);
            this.orderDateL.Name = "orderDateL";
            this.orderDateL.Size = new System.Drawing.Size(60, 15);
            this.orderDateL.TabIndex = 5;
            this.orderDateL.Text = "orderDate";
            // 
            // statusL
            // 
            this.statusL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.statusL.AutoSize = true;
            this.statusL.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.statusL.Location = new System.Drawing.Point(410, 69);
            this.statusL.Name = "statusL";
            this.statusL.Size = new System.Drawing.Size(57, 23);
            this.statusL.TabIndex = 6;
            this.statusL.Text = "status";
            // 
            // orderTypeL
            // 
            this.orderTypeL.AutoSize = true;
            this.orderTypeL.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderTypeL.Location = new System.Drawing.Point(4, 77);
            this.orderTypeL.Name = "orderTypeL";
            this.orderTypeL.Size = new System.Drawing.Size(79, 23);
            this.orderTypeL.TabIndex = 7;
            this.orderTypeL.Text = "orderType";
            // 
            // doneOrderBtn
            // 
            this.doneOrderBtn.Location = new System.Drawing.Point(420, 95);
            this.doneOrderBtn.Name = "doneOrderBtn";
            this.doneOrderBtn.Size = new System.Drawing.Size(75, 23);
            this.doneOrderBtn.TabIndex = 8;
            this.doneOrderBtn.Text = "Done";
            this.doneOrderBtn.UseVisualStyleBackColor = true;
            this.doneOrderBtn.Click += new System.EventHandler(this.doneOrderBtn_Click);
            // 
            // OrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.doneOrderBtn);
            this.Controls.Add(this.orderTypeL);
            this.Controls.Add(this.statusL);
            this.Controls.Add(this.orderDateL);
            this.Controls.Add(this.priceL);
            this.Controls.Add(this.employeeL);
            this.Controls.Add(this.ownerPhoneL);
            this.Controls.Add(this.ownerNameL);
            this.Controls.Add(this.carL);
            this.Name = "OrderControl";
            this.Size = new System.Drawing.Size(507, 132);
            this.Load += new System.EventHandler(this.OrderControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label carL;
        private System.Windows.Forms.Label ownerNameL;
        private System.Windows.Forms.Label ownerPhoneL;
        private System.Windows.Forms.Label employeeL;
        private System.Windows.Forms.Label priceL;
        private System.Windows.Forms.Label orderDateL;
        private System.Windows.Forms.Label statusL;
        private System.Windows.Forms.Label orderTypeL;
        private System.Windows.Forms.Button doneOrderBtn;
    }
}
