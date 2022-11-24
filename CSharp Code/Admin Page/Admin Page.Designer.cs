namespace WA_Vrushivar
{
    partial class Admin_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Page));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnADLogin = new System.Windows.Forms.Button();
            this.txtAdminPin = new System.Windows.Forms.TextBox();
            this.txtAdminID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lnklblTrackOrder = new System.Windows.Forms.LinkLabel();
            this.lnklblAssignTask = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabel_NewProduct = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnDown);
            this.panel1.Controls.Add(this.btnUp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(926, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 500);
            this.panel1.TabIndex = 0;
            // 
            // btnDown
            // 
            this.btnDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDown.Location = new System.Drawing.Point(0, 465);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(40, 35);
            this.btnDown.TabIndex = 2;
            this.btnDown.Text = "DN";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUp.Location = new System.Drawing.Point(0, 0);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(40, 40);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "UP";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnADLogin);
            this.panel2.Controls.Add(this.txtAdminPin);
            this.panel2.Controls.Add(this.txtAdminID);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(871, 104);
            this.panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Navy;
            this.btnCancel.Location = new System.Drawing.Point(655, 45);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnADLogin
            // 
            this.btnADLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADLogin.ForeColor = System.Drawing.Color.Navy;
            this.btnADLogin.Location = new System.Drawing.Point(544, 45);
            this.btnADLogin.Name = "btnADLogin";
            this.btnADLogin.Size = new System.Drawing.Size(75, 35);
            this.btnADLogin.TabIndex = 5;
            this.btnADLogin.Text = "Login";
            this.btnADLogin.UseVisualStyleBackColor = true;
            this.btnADLogin.Click += new System.EventHandler(this.btnADLogin_Click);
            // 
            // txtAdminPin
            // 
            this.txtAdminPin.BackColor = System.Drawing.SystemColors.Info;
            this.txtAdminPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminPin.ForeColor = System.Drawing.Color.Red;
            this.txtAdminPin.Location = new System.Drawing.Point(329, 60);
            this.txtAdminPin.Multiline = true;
            this.txtAdminPin.Name = "txtAdminPin";
            this.txtAdminPin.Size = new System.Drawing.Size(176, 35);
            this.txtAdminPin.TabIndex = 4;
            // 
            // txtAdminID
            // 
            this.txtAdminID.BackColor = System.Drawing.SystemColors.Info;
            this.txtAdminID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminID.ForeColor = System.Drawing.Color.Red;
            this.txtAdminID.Location = new System.Drawing.Point(329, 16);
            this.txtAdminID.Multiline = true;
            this.txtAdminID.Name = "txtAdminID";
            this.txtAdminID.Size = new System.Drawing.Size(176, 35);
            this.txtAdminID.TabIndex = 3;
            this.txtAdminID.TextChanged += new System.EventHandler(this.txtAdminID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(193, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Admin Pin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(204, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admin ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Login";
            // 
            // lnklblTrackOrder
            // 
            this.lnklblTrackOrder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lnklblTrackOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblTrackOrder.LinkColor = System.Drawing.Color.White;
            this.lnklblTrackOrder.Location = new System.Drawing.Point(3, 58);
            this.lnklblTrackOrder.Name = "lnklblTrackOrder";
            this.lnklblTrackOrder.Size = new System.Drawing.Size(296, 29);
            this.lnklblTrackOrder.TabIndex = 0;
            this.lnklblTrackOrder.TabStop = true;
            this.lnklblTrackOrder.Text = "3. Track Order";
            this.lnklblTrackOrder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblTrackOrder_LinkClicked);
            // 
            // lnklblAssignTask
            // 
            this.lnklblAssignTask.AutoSize = true;
            this.lnklblAssignTask.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lnklblAssignTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblAssignTask.LinkColor = System.Drawing.Color.White;
            this.lnklblAssignTask.Location = new System.Drawing.Point(3, 29);
            this.lnklblAssignTask.Name = "lnklblAssignTask";
            this.lnklblAssignTask.Size = new System.Drawing.Size(296, 29);
            this.lnklblAssignTask.TabIndex = 1;
            this.lnklblAssignTask.TabStop = true;
            this.lnklblAssignTask.Text = "2. Assign Task To Team";
            this.lnklblAssignTask.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblAssignTask_LinkClicked);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel3.Controls.Add(this.linkLabel_NewProduct);
            this.flowLayoutPanel3.Controls.Add(this.lnklblAssignTask);
            this.flowLayoutPanel3.Controls.Add(this.lnklblTrackOrder);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(401, 190);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(436, 124);
            this.flowLayoutPanel3.TabIndex = 4;
            this.flowLayoutPanel3.Visible = false;
            // 
            // linkLabel_NewProduct
            // 
            this.linkLabel_NewProduct.AutoSize = true;
            this.linkLabel_NewProduct.BackColor = System.Drawing.Color.Black;
            this.linkLabel_NewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_NewProduct.LinkColor = System.Drawing.Color.White;
            this.linkLabel_NewProduct.Location = new System.Drawing.Point(3, 0);
            this.linkLabel_NewProduct.Name = "linkLabel_NewProduct";
            this.linkLabel_NewProduct.Size = new System.Drawing.Size(257, 29);
            this.linkLabel_NewProduct.TabIndex = 2;
            this.linkLabel_NewProduct.TabStop = true;
            this.linkLabel_NewProduct.Text = "1. ADD New Product ";
            this.linkLabel_NewProduct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_NewProduct_LinkClicked);
            // 
            // Admin_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(966, 500);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Admin_Page";
            this.Text = "Admin_Page";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnADLogin;
        private System.Windows.Forms.TextBox txtAdminPin;
        private System.Windows.Forms.TextBox txtAdminID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnklblTrackOrder;
        private System.Windows.Forms.LinkLabel lnklblAssignTask;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.LinkLabel linkLabel_NewProduct;
    }
}