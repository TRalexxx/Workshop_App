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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 494);
            this.Controls.Add(this.showOrdersBtn);
            this.Controls.Add(this.ordersPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ordersPanel;
        private System.Windows.Forms.Button showOrdersBtn;
    }
}

