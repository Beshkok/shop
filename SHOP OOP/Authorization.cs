using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Components;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace SHOP_OOP
{
    public partial class Authorization : MetroForm
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signIn_Click(object sender, EventArgs e)
        {
            string loginField = login.Text;
            string passField = password.Text;

            DB db = new DB();
            DataTable dt = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE `login` = @userLogin AND `password` = @userPassword", db.GetConnection());

            command.Parameters.Add("@userLogin", MySqlDbType.VarChar).Value = loginField;
            command.Parameters.Add("@userPassword", MySqlDbType.VarChar).Value = passField;

            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                Orders ord = new Orders();
                this.Hide();
                ord.user = loginField;
                ord.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неверно введены логин или пароль!");
            }
        }
    }
}
