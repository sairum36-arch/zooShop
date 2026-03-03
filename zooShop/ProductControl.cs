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
    public partial class ProductControl : UserControl
    {
        private static string connectionString = "Database=zooShop;Username=postgres;Host=localhost;Password=1;Port=5432";
        public string ProductArticle { get; private set; }

        public ProductControl()
        {
            InitializeComponent();
        }
        public void SetData(string article, string name, string category, string description, string manufactory, string supplier, decimal price, string unit, int quantity, int discount, string photo_url)
        {
            this.ProductArticle = article; 
            lblName.Text = "Название: " + name;
            lblCategory.Text = "Категория: " + category;
            lblDescription.Text = "Описание: " + description;
            lblManufactory.Text = "Производитель: " + manufactory;
            lblSupplier.Text = "Поставщик: " + supplier;
            lblUnit.Text = "Единица измерения: " + unit;
            lblQuantity.Text = "Количество на складе: " + quantity;
            if (discount > 0)
            {
                decimal newPrice = price - (price * discount / 100);
                lblPrice.Text = $"Цена: {price:F2} -> {newPrice:F2} руб.";
                lblPrice.ForeColor = Color.Red;
                labelDiscount.Text = $"Скидка: {discount}%";
            }
            else
            {
                lblPrice.Text = $"Цена: {price:F2} руб.";
                lblPrice.ForeColor = Color.Black;
                lblPrice.Font = new Font(lblPrice.Font, FontStyle.Regular); 
                labelDiscount.Text = "";
            }
            string dbFileName = photo_url?.ToString().Trim();
            string folder = Path.Combine(Application.StartupPath, "images");
            string placeholder = Path.Combine(folder, "picture.jpg");
            if (string.IsNullOrWhiteSpace(dbFileName) || !File.Exists(Path.Combine(folder, dbFileName)))
            {
                pBox.ImageLocation = placeholder;
            }
            else
            {
                pBox.ImageLocation = Path.Combine(folder, dbFileName);
            }
            this.BackColor = Color.White; 
            if (quantity == 0)
            {
                this.BackColor = Color.LightBlue;
            }
            else if (discount > 15)
            {
                this.BackColor = ColorTranslator.FromHtml("#67D31D"); 
            }
            if (Program.currentRole == 1)
            {
                button1.Visible = true; 
                button2.Visible = true; 
            }
            else
            {
                button1.Visible = false;
                button2.Visible = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddProduct form = new AddProduct(this.ProductArticle);
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (this.ParentForm is MainForm main)
                {
                    main.UpdateProducts();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите удалить этот товар?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var conn = new NpgsqlConnection(connectionString))
                    {
                        conn.Open();
                        string sql = "DELETE FROM product WHERE article = @art";
                        using (var cmd = new NpgsqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("art", this.ProductArticle);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Товар успешно удален!");
                    this.Visible = false;
                }
                catch (PostgresException ex)
                {
                    MessageBox.Show("Нельзя удалить этот товар, так как он присутствует в заказах!\n\nДетали: " + ex.MessageText, "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла неизвестная ошибка:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ProductControl_Load(object sender, EventArgs e)
        {
        }
    }
}
