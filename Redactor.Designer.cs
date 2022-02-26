
namespace SHOP_OOP
{
    partial class Redactor
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
            this.CanselButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.OrderBox = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.FIO = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CanselButton
            // 
            this.CanselButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CanselButton.Location = new System.Drawing.Point(398, 383);
            this.CanselButton.Name = "CanselButton";
            this.CanselButton.Size = new System.Drawing.Size(123, 43);
            this.CanselButton.TabIndex = 19;
            this.CanselButton.Text = "Отмена";
            this.CanselButton.UseVisualStyleBackColor = false;
            this.CanselButton.Click += new System.EventHandler(this.CanselButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddButton.Location = new System.Drawing.Point(661, 383);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(116, 43);
            this.AddButton.TabIndex = 18;
            this.AddButton.Text = "Сохранить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // OrderBox
            // 
            this.OrderBox.Location = new System.Drawing.Point(208, 145);
            this.OrderBox.Multiline = true;
            this.OrderBox.Name = "OrderBox";
            this.OrderBox.Size = new System.Drawing.Size(569, 131);
            this.OrderBox.TabIndex = 17;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(208, 282);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(188, 22);
            this.Phone.TabIndex = 16;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(208, 317);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(569, 22);
            this.Address.TabIndex = 15;
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(208, 105);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(569, 22);
            this.FIO.TabIndex = 14;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(132, 317);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(49, 20);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Адрес";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(127, 282);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 20);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Телефон";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(127, 145);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 20);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Заказ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(74, 105);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 20);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "ФИО клиента";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(527, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 43);
            this.button1.TabIndex = 20;
            this.button1.Text = "Удалить заказ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Обработан",
            "Отправлен"});
            this.comboBox1.Location = new System.Drawing.Point(127, 393);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Статус: ";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(174, 424);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(0, 0);
            this.metroLabel5.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(600, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 43);
            this.button2.TabIndex = 24;
            this.button2.Text = "Заказ доставлен";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Redactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 501);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
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
            this.Name = "Redactor";
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.Redactor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CanselButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox OrderBox;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox FIO;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.Button button2;
    }
}