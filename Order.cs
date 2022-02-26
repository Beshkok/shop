using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;

namespace SHOP_OOP
{
    public partial class Order : MetroForm
    {
        public Order()
        {
            InitializeComponent();
        }

        private void CanselButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string fio = FIO.Text;
            string order = OrderBox.Text;
            string phone = Phone.Text;
            string address = Address.Text;

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO orders (`client_name`, `phone_number`, `order_text`, `address`) VALUES (@fio, @phone, @order, @address)", db.GetConnection());


            command.Parameters.Add("@fio", MySqlDbType.VarChar).Value = fio;
            command.Parameters.Add("@order", MySqlDbType.VarChar).Value = order;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;

            db.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Заказ успешно добавлен!");
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }

            this.Hide();

            db.closeConnection();


        }
    }
}
