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
    public partial class AddProduct : Form
    {
        private static string connectionString = "Database=zooShop;Username=postgres;Host=localhost;Password=1;Port=5432";

        string currentProductId = null;

        public AddProduct(string id)
        {
            InitializeComponent();
            this.currentProductId = id;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

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

        private void LoadProduct()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var sql = @"SELECT * FROM product WHERE id = @id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("id", currentProductId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtDescription.Text = reader["description"].ToString();
                            txtName.Text = reader["name"].ToString();
                            numDiscount.Value = Convert.ToInt32(reader["discount"]);
                            numPrice.Value = Convert.ToDecimal(reader["price"]);
                            numQuantity.Value = Convert.ToInt32(reader["quantity"]);
                            SelectComboItem(cmbCategory, reader["category_id"]);
                            SelectComboItem(cmbManufactory, reader["manufactory_id"]);
                            SelectComboItem(cmbSupplier, reader["delivery_id"]);
                            SelectComboItem(cmbUnit, reader["unit_id"]);

                        }

                    }
                }
            }
        }



        private void AddProduct_Load(object sender, EventArgs e)
        {
            FillComboBox(cmbCategory, "product_category", "name");
            FillComboBox(cmbManufactory, "manufactory", "name");
            FillComboBox(cmbSupplier, "supplier", "name");
            FillComboBox(cmbUnit, "product_unit", "name");

            if (currentProductId == null)
            {
                this.Text = "Добавление";
                txtDescription.Text = "";
                txtName.Text = "Name";
                numDiscount.Value = 0;
                numPrice.Value = 0;
                numQuantity.Value = 0;
                cmbUnit.SelectedIndex = 0;
                cmbSupplier.SelectedIndex = 0;
                cmbManufactory.SelectedIndex = 0;
                cmbCategory.SelectedIndex = 0;
            }
            else
            {
                this.Text = "Редактирование";



            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Введите название товара");
                return;
            }
            if (cmbCategory.SelectedItem == null || cmbSupplier.SelectedItem == null)
            {
                MessageBox.Show("Выберете категорию и поставщика");
                return;
            }
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string sql;
                    if (currentProductId == null)
                    {
                        sql = @"INSERT INTO product (name, description, price, quantity, discount, category_id, manufactory_id,
                        delivery_id, unit_id) VALUES (@name, @desc, @price, @quantity, @discount, @category, @manufactory, @supplier, @unit)";

                    }
                    else
                    {
                        sql = @"UPDATE  product SET name = @name, description = @desc, price = @price, quantity = @quantity,
                        discount = @discount, category_id = @category, manufactory_id = @manufactory, delivery_id = @supplier, 
                        unit_id = @unit;";
                    }
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("desc", txtDescription.Text.Trim());
                        cmd.Parameters.AddWithValue("price", numPrice.Value);
                        cmd.Parameters.AddWithValue("quantity", numQuantity.Value);
                        cmd.Parameters.AddWithValue("discount", numDiscount.Value);
                        cmd.Parameters.AddWithValue("category", ((dynamic)cmbCategory.SelectedItem).Id);
                        cmd.Parameters.AddWithValue("manufactory", ((dynamic)cmbManufactory.SelectedItem).Id);
                        cmd.Parameters.AddWithValue("supplier", ((dynamic)cmbSupplier.SelectedItem).Id);
                        cmd.Parameters.AddWithValue("unit", ((dynamic)cmbUnit.SelectedItem).Id);

                        if (currentProductId != null)
                        {
                            cmd.Parameters.AddWithValue("id", currentProductId);
                        }
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Товар сохранен");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка" + ex);
            }
        }
    }
}
