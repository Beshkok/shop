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
    public partial class Redactor : MetroForm
    {
        public Redactor()
        {
            InitializeComponent();
        }

        public int id;
        public string name;
        public string order;
        public string phone;
        public string address;
        public string user;

        private void Redactor_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand command2 = new MySqlCommand("SELECT * FROM orders WHERE `id` = @id", db.GetConnection());

            command2.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            db.openConnection();

            MySqlDataReader reader = command2.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Text = reader[5].ToString();
                metroLabel5.Text = reader[5].ToString();
            }

            db.closeConnection();

            FIO.Text = name;
            OrderBox.Text = order;
            Phone.Text = phone;
            Address.Text = address;

            if(user == "root")
            {
                comboBox1.Hide();
                button2.Hide();
            }
            else
            {
                label1.Hide();
                metroLabel5.Hide();
            }
            if (user == "kurer")
            {
                FIO.ReadOnly = true;
                OrderBox.ReadOnly = true;
                Phone.ReadOnly = true;
                Address.ReadOnly = true;
                comboBox1.Hide();
                button1.Hide();
                CanselButton.Hide();
                AddButton.Hide();
            }
            if (user == "admin")
            {
                button2.Hide();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            string fio = FIO.Text;
            string order = OrderBox.Text;
            string phone = Phone.Text;
            string address = Address.Text;
            string status = comboBox1.Text;

            MySqlCommand command = new MySqlCommand("UPDATE orders SET `client_name` = @fio, `order_text` = @order, `phone_number` = @phone, `address` = @address, `status` = @status  WHERE `id` = @id", db.GetConnection());


            command.Parameters.Add("@fio", MySqlDbType.VarChar).Value = fio;
            command.Parameters.Add("@order", MySqlDbType.VarChar).Value = order;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = status;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Данные обновлены!");
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }

            this.Hide();

            db.closeConnection();
        }

        private void CanselButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            string fio = FIO.Text;
            string order = OrderBox.Text;
            string phone = Phone.Text;
            string address = Address.Text;


            MySqlCommand command = new MySqlCommand("DELETE FROM orders WHERE `id` = @id", db.GetConnection());

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Заказ удален!");
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }

            this.Hide();

            db.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("UPDATE orders SET `status` = 'Доставлено'  WHERE `id` = @id", db.GetConnection());

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Отлично!");
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }

            db.closeConnection();

            this.Hide();

        }
    }
}
