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
    public partial class Orders : MetroForm
    {
        public string user;
        public Orders()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void добавитьЗаказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order ord = new Order();
            ord.ShowDialog();
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info spravka = new Info();
            spravka.ShowDialog();
        }

        public void Header()
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "id";
            column1.Width = 100;
            column1.Name = "id";
            column1.CellTemplate = new DataGridViewTextBoxCell();

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "ФИО клиента";
            column2.Width = 100;
            column2.Name = "FIO";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Телефон";
            column3.Width = 100;
            column3.Name = "FIO";
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Заказ";
            column4.Width = 100;
            column4.Name = "order";
            column4.CellTemplate = new DataGridViewTextBoxCell();

            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Адрес";
            column5.Width = 100;
            column5.Name = "address";
            column5.CellTemplate = new DataGridViewTextBoxCell();

            Output.Columns.Add(column1);
            Output.Columns.Add(column2);
            Output.Columns.Add(column3);
            Output.Columns.Add(column4);
            Output.Columns.Add(column5);

            Output.AllowUserToAddRows = false;
            Output.ReadOnly = true;
        }

        private void AddData(DataRow row)
        {
            Output.Rows.Add(row.id, row.client_name, row.phone_number, row.order_text, row.address);
        }

        private void Orders_Shown(object sender, EventArgs e)
        {
            Header();

            List < DataRow > data = new List<DataRow>();

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("SELECT * FROM orders", db.GetConnection());

            MySqlDataReader reader;

            try
            {
                db.openConnection();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DataRow row = new DataRow(reader["id"], reader["client_name"], reader["phone_number"], reader["order_text"], reader["address"]);
                    data.Add(row);
                }

                for (int i =0; i < data.Count; i++)
                {
                    AddData(data[i]);
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                db.closeConnection();
            }


        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            List<DataRow> data = new List<DataRow>();

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("SELECT * FROM orders WHEREr", db.GetConnection());
            MySqlDataReader reader;

            db.openConnection();
            reader = command.ExecuteReader();

            Output.DataSource = null;

            Output.Rows.Clear();

            try
            {

                while (reader.Read())
                {
                    DataRow row = new DataRow(reader["id"], reader["client_name"], reader["phone_number"], reader["order_text"], reader["address"]);
                    data.Add(row);
                }

                for (int i = 0; i < data.Count; i++)
                {
                    AddData(data[i]);
                }

                MessageBox.Show("Данные обновлены!");
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void Output_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = Output.Rows[e.RowIndex].Cells[0].Value.ToString();
            string client = Output.Rows[e.RowIndex].Cells[1].Value.ToString();
            string order = Output.Rows[e.RowIndex].Cells[3].Value.ToString();
            string phone = Output.Rows[e.RowIndex].Cells[2].Value.ToString();
            string address = Output.Rows[e.RowIndex].Cells[4].Value.ToString();
            Redactor red = new Redactor();
            red.id = Convert.ToInt32(id);
            red.name = client;
            red.order = order;
            red.phone = phone;
            red.address = address;
            red.user = user;
            red.ShowDialog();
        }
    }
}
