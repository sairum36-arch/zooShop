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
    public partial class MainForm : Form
    {
        private static string connectionString = "Database=zooShop;Username=postgres;Host=localhost;Password=1;Port=5432";

      

        public MainForm()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateSupplier()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Все производители");
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT name FROM supplier";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, connection))
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["name"].ToString());
                    }
                }
                comboBox1.SelectedIndex = 0;

            }
        }

        public void UpdateProducts()
        {
            flowLayoutPanel1.Controls.Clear();
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string sql = @"SELECT p.article, p.name as product_name, u.name as unit_name, price, s.name as supplier_name, m.name as manufactory_name, pc.name as product_category_name, p.discount, p.quantity, p.description, p.photo_url
        FROM public.product p
        JOIN product_unit u ON p.unit_id = u.id
        JOIN supplier s ON p.delivery_id = s.id
        JOIN manufactory m ON p.manufactory_id = m.id
        JOIN product_category pc ON p.category_id = pc.id
        WHERE 1 = 1";
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    sql += $" AND (p.name ILIKE '%{textBox1.Text}%')";
                }
                if (comboBox1.SelectedIndex > 0)
                {
                    string selectedSup = comboBox1.SelectedItem.ToString();
                    sql += $" AND s.name = '{selectedSup}'";
                }
                if (numericUpDown1.Value > 0)
                {
                    decimal numberQuantity = numericUpDown1.Value;
                    sql += $" AND p.quantity = {numberQuantity}";
                }
                using (var cmd = new NpgsqlCommand(sql, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ProductControl productControl = new ProductControl();
                        productControl.SetData(
                            reader["article"].ToString(),     
                            reader["product_name"].ToString(), 
                            reader["product_category_name"].ToString(),
                            reader["description"].ToString(),  
                            reader["manufactory_name"].ToString(), 
                            reader["supplier_name"].ToString(), 
                            Convert.ToDecimal(reader["price"]), 
                            reader["unit_name"].ToString(),    
                            Convert.ToInt32(reader["quantity"]),
                            Convert.ToInt32(reader["discount"]),
                            reader["photo_url"].ToString()
                        );

                        flowLayoutPanel1.Controls.Add(productControl);
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProducts();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateProducts();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateProducts();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateSupplier();
            UpdateProducts();
            int role = Program.currentRole;
            switch (role)
            {


                case 1:
                    btnAddProduct.Visible = true;
                    btnOrders.Visible = true;
                    comboBox1.Enabled = true;
                    textBox1.Enabled = true;
                    numericUpDown1.Enabled = true;
                    break;
                case 2:
                    btnAddProduct.Visible = false;
                    btnOrders.Visible = false;
                    comboBox1.Enabled = true;
                    textBox1.Enabled = true;
                    numericUpDown1.Enabled = true;
                    break;
                case 3:
                    btnAddProduct.Visible = false;
                    btnOrders.Visible = false;
                    comboBox1.Enabled = false;
                    textBox1.Enabled = false;
                    numericUpDown1.Enabled = false;
                    break;
                default:
                    btnAddProduct.Visible = false;
                    btnOrders.Visible = false;
                    comboBox1.Enabled = false;
                    textBox1.Enabled = false;
                    numericUpDown1.Enabled = false;
                    break;


            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct form = new AddProduct(null);
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateProducts();
            }

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OrdersForm form = new OrdersForm();
            this.Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            Program.currentRole = 0;
            this.Close();
            loginForm.Show();
            
        }
    }
}
