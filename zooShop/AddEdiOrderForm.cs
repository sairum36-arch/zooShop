using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zooShop
{
    public partial class AddEdiOrderForm : Form
    {
        private string connectionString = "Database=zooShop;Username=postgres;Host=localhost;Password=1;Port=5432";
        public int OrderID = 0;

        public AddEdiOrderForm(int id)
        {
            InitializeComponent();
            this.OrderID = id;
        }

        private void AddEdiOrderForm_Load(object sender, EventArgs e)
        {
            FillComboBox(cmbStatus, "order_staus", "name");
            if (OrderID > 0)
            {
                this.Text = "Редактирование заказа №" + OrderID;
                LoadOrderData();
            }
            else
            {
                this.Text = "Новый заказ";
                dtpDelivery.Value = DateTime.Now.AddDays(3);
            }
        }

        private void LoadOrderData()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT order_status_id, date_of_delivery FROM orders WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("id", OrderID);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (reader["date_of_delivery"] != DBNull.Value)
                            dtpDelivery.Value = Convert.ToDateTime(reader["date_of_delivery"]);
                        SelectComboItem(cmbStatus, reader["order_status_id"]);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string sql = "";
                int statusId = ((dynamic)cmbStatus.SelectedItem).Id;
                if (OrderID > 0)
                {
                    sql = "UPDATE orders SET order_status_id = @sid, date_of_delivery = @date WHERE id = @oid";
                }
                else
                {
                    sql = "INSERT INTO orders (order_status_id, date_of_delivery, date_of_purchase, code_of_pick) VALUES (@sid, @date, current_date, 1234)";
                }

                var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("sid", statusId);
                cmd.Parameters.AddWithValue("date", dtpDelivery.Value);
                if (OrderID > 0) cmd.Parameters.AddWithValue("oid", OrderID);

                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Заказ сохранен!");
            this.DialogResult = DialogResult.OK; 
            this.Close();
        }
        private void FillComboBox(ComboBox comboBox, string table, string columnName)
        {
            comboBox.DataSource = null;
            comboBox.Items.Clear();
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string sql = $"SELECT id, {columnName} FROM {table}";
                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new { Id = reader["id"], Name = reader["name"].ToString() };
                        comboBox.Items.Add(item);
                    }
                }
            }
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";
            comboBox.SelectedIndex = 0;

        }

        void SelectComboItem(ComboBox comboBox, object id)
        {
            foreach (dynamic item in comboBox.Items)
            {
                if (item.Id.ToString() == id.ToString())
                {
                    comboBox.SelectedItem = item;
                    break;
                }
            }
        }
    }
}

