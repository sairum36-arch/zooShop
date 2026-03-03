using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace zooShop
{
    public partial class OrdersForm : Form
    {
        private static string connectionString = "Database=zooShop;Username=postgres;Host=localhost;Password=1;Port=5432";

        public OrdersForm()
        {
            InitializeComponent();
        }

        public void LoadOrders()
        {
            flowLayoutPanel1.Controls.Clear();
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"
                    SELECT 
                    o.id, 
                    o.date_of_purchase, 
                    o.date_of_delivery, 
                    o.code_of_pick,
                    u.fio as client_name, 
                    s.status_name as status_name, 
                    STRING_AGG(po.article, ', ') as product_articles 
                    FROM orders o
                    JOIN users u ON o.user_id = u.id
                    JOIN order_staus s ON o.order_status_id = s.id
                    LEFT JOIN product_orders po ON o.id = po.order_id
                    GROUP BY o.id, client_name, status_name, o.date_of_purchase, o.date_of_delivery, o.code_of_pick
                    ORDER BY o.date_of_purchase DESC";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OrderControl1 item = new OrderControl1();
                            item.SetData(
                                Convert.ToInt32(reader["id"]),
                                Convert.ToDateTime(reader["date_of_purchase"]),
                                reader["status_name"].ToString(),
                                reader["client_name"].ToString(),
                                reader["product_articles"].ToString()
                            );
                            flowLayoutPanel1.Controls.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки заказов: " + ex.Message);
            }
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddEdiOrderForm form = new AddEdiOrderForm(0);
            form.ShowDialog();
            LoadOrders();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
