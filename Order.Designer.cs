
namespace SHOP_OOP
{
    partial class Order
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.FIO = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.OrderBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CanselButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(43, 133);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ФИО клиента";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(96, 173);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Заказ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(96, 310);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 20);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Телефон";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(101, 345);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(49, 20);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Адрес";
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(177, 133);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(569, 22);
            this.FIO.TabIndex = 4;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(177, 345);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(569, 22);
            this.Address.TabIndex = 5;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(177, 310);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(188, 22);
            this.Phone.TabIndex = 6;
            // 
            // OrderBox
            // 
            this.OrderBox.Location = new System.Drawing.Point(177, 173);
            this.OrderBox.Multiline = true;
            this.OrderBox.Name = "OrderBox";
            this.OrderBox.Size = new System.Drawing.Size(569, 131);
            this.OrderBox.TabIndex = 7;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddButton.Location = new System.Drawing.Point(614, 411);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(132, 43);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CanselButton
            // 
            this.CanselButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CanselButton.Location = new System.Drawing.Point(454, 411);
            this.CanselButton.Name = "CanselButton";
            this.CanselButton.Size = new System.Drawing.Size(132, 43);
            this.CanselButton.TabIndex = 9;
            this.CanselButton.Text = "Отмена";
            this.CanselButton.UseVisualStyleBackColor = false;
            this.CanselButton.Click += new System.EventHandler(this.CanselButton_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 477);
            this.Controls.Add(this.CanselButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.OrderBox);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Order";
            this.Text = "Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox OrderBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CanselButton;
    }
}