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
    public partial class OrderControl1 : UserControl
    {
        public int OrderID { get; set; }

        public OrderControl1()
        {
            InitializeComponent();
        }

        public void SetData(int id, DateTime date, string status, string client, string articles)
        {
            this.OrderID = id;
            lblOrderNumber.Text = "Заказ № " + id;
            lblDateOrder.Text = "Дата заказа: " + date.ToShortDateString();
            lblStatus.Text = "Статус: " + status;
            lblClient.Text = "Клиент: " + client;
            lblDelivery.Text = "Состав: " + (string.IsNullOrEmpty(articles) ? "не указан" : articles);
            lblCode.Visible = false;
            lblPickupPoint.Visible = false;
            if (status == "Новый")
            {
                this.BackColor = Color.FromArgb(244, 232, 211);
            }
            else
            {
                this.BackColor = Color.White;
            }
            btnRedact.Visible = (Program.currentRole == 1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRedact_Click(object sender, EventArgs e)
        {
            AddEdiOrderForm form = new AddEdiOrderForm(this.OrderID);
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ((OrdersForm)this.ParentForm).LoadOrders();
                }
                catch { }
                
            }
        }

        private void dtnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
