namespace zooShop
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            flowLayoutPanel1 = new FlowLayoutPanel();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            btnAddProduct = new Button();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            btnOrders = new Button();
            button1 = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(120, 219, 226);
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(905, 666);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(120, 219, 226);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(937, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 24);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(937, 12);
            label1.Name = "label1";
            label1.Size = new Size(64, 23);
            label1.TabIndex = 2;
            label1.Text = "Поиск:";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(120, 219, 226);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(937, 109);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 31);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(937, 83);
            label2.Name = "label2";
            label2.Size = new Size(103, 23);
            label2.TabIndex = 4;
            label2.Text = "Поставщик:";
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.FromArgb(235, 15, 15);
            btnAddProduct.FlatAppearance.BorderSize = 0;
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Location = new Point(3, 3);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(210, 55);
            btnAddProduct.TabIndex = 5;
            btnAddProduct.Text = "Добавить товар";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(120, 219, 226);
            numericUpDown1.BorderStyle = BorderStyle.None;
            numericUpDown1.Location = new Point(937, 181);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(213, 27);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(937, 155);
            label3.Name = "label3";
            label3.Size = new Size(190, 23);
            label3.TabIndex = 7;
            label3.Text = "Количество на складе:";
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.FromArgb(235, 15, 15);
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Location = new Point(3, 64);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(210, 51);
            btnOrders.TabIndex = 8;
            btnOrders.Text = "Заказы";
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += btnOrders_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = Color.FromArgb(235, 15, 15);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(3, 121);
            button1.Name = "button1";
            button1.Size = new Size(210, 52);
            button1.TabIndex = 9;
            button1.Text = "Выйти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Bottom;
            flowLayoutPanel2.BackColor = Color.FromArgb(120, 219, 226);
            flowLayoutPanel2.Controls.Add(btnAddProduct);
            flowLayoutPanel2.Controls.Add(btnOrders);
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(937, 501);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(220, 177);
            flowLayoutPanel2.TabIndex = 10;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1162, 690);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Главное меню";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Button btnAddProduct;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Button btnOrders;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}