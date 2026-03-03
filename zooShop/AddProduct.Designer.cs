namespace zooShop
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cmbCategory = new ComboBox();
            label3 = new Label();
            cmbManufactory = new ComboBox();
            cmbSupplier = new ComboBox();
            label4 = new Label();
            numPrice = new NumericUpDown();
            label5 = new Label();
            cmbUnit = new ComboBox();
            label6 = new Label();
            numQuantity = new NumericUpDown();
            label7 = new Label();
            numDiscount = new NumericUpDown();
            label8 = new Label();
            btnAdd = new Button();
            btnClose = new Button();
            label9 = new Label();
            txtDescription = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDiscount).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(14, 15);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 224);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(235, 15, 15);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(77, 247);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(114, 29);
            button1.TabIndex = 1;
            button1.Text = "Выбрать фото";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(120, 219, 226);
            txtName.BorderStyle = BorderStyle.None;
            txtName.Location = new Point(431, 15);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(170, 20);
            txtName.TabIndex = 2;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(308, 15);
            label1.Name = "label1";
            label1.Size = new Size(118, 19);
            label1.TabIndex = 3;
            label1.Text = "Наименование:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(342, 61);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 4;
            label2.Text = "Категория:";
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.FromArgb(120, 219, 226);
            cmbCategory.FlatStyle = FlatStyle.Flat;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(432, 61);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(170, 27);
            cmbCategory.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(306, 108);
            label3.Name = "label3";
            label3.Size = new Size(119, 19);
            label3.TabIndex = 6;
            label3.Text = "Производитель:";
            // 
            // cmbManufactory
            // 
            cmbManufactory.BackColor = Color.FromArgb(120, 219, 226);
            cmbManufactory.FlatStyle = FlatStyle.Flat;
            cmbManufactory.FormattingEnabled = true;
            cmbManufactory.Location = new Point(431, 108);
            cmbManufactory.Name = "cmbManufactory";
            cmbManufactory.Size = new Size(171, 27);
            cmbManufactory.TabIndex = 7;
            // 
            // cmbSupplier
            // 
            cmbSupplier.BackColor = Color.FromArgb(120, 219, 226);
            cmbSupplier.FlatStyle = FlatStyle.Flat;
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(431, 156);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(170, 27);
            cmbSupplier.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(337, 159);
            label4.Name = "label4";
            label4.Size = new Size(88, 19);
            label4.TabIndex = 9;
            label4.Text = "Поставщик:";
            // 
            // numPrice
            // 
            numPrice.BackColor = Color.FromArgb(120, 219, 226);
            numPrice.BorderStyle = BorderStyle.None;
            numPrice.Location = new Point(432, 204);
            numPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(170, 23);
            numPrice.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(377, 204);
            label5.Name = "label5";
            label5.Size = new Size(48, 19);
            label5.TabIndex = 11;
            label5.Text = "Цена:";
            // 
            // cmbUnit
            // 
            cmbUnit.BackColor = Color.FromArgb(120, 219, 226);
            cmbUnit.FlatStyle = FlatStyle.Flat;
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(431, 249);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(170, 27);
            cmbUnit.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(272, 252);
            label6.Name = "label6";
            label6.Size = new Size(154, 19);
            label6.TabIndex = 13;
            label6.Text = "Еденица измерения:";
            // 
            // numQuantity
            // 
            numQuantity.BackColor = Color.FromArgb(120, 219, 226);
            numQuantity.BorderStyle = BorderStyle.None;
            numQuantity.Location = new Point(432, 297);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(169, 23);
            numQuantity.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(262, 299);
            label7.Name = "label7";
            label7.Size = new Size(164, 19);
            label7.TabIndex = 15;
            label7.Text = "Количество на складе:";
            // 
            // numDiscount
            // 
            numDiscount.BackColor = Color.FromArgb(120, 219, 226);
            numDiscount.BorderStyle = BorderStyle.None;
            numDiscount.Location = new Point(431, 348);
            numDiscount.Name = "numDiscount";
            numDiscount.Size = new Size(170, 23);
            numDiscount.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(363, 348);
            label8.Name = "label8";
            label8.Size = new Size(62, 19);
            label8.TabIndex = 17;
            label8.Text = "Скидка:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(235, 15, 15);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAdd.Location = new Point(271, 531);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(154, 48);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(235, 15, 15);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(272, 585);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(154, 48);
            btnClose.TabIndex = 19;
            btnClose.Text = "Назад";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(262, 391);
            label9.Name = "label9";
            label9.Size = new Size(82, 19);
            label9.TabIndex = 20;
            label9.Text = "Описание:";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.FromArgb(120, 219, 226);
            txtDescription.Location = new Point(360, 391);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(242, 111);
            txtDescription.TabIndex = 21;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(665, 673);
            Controls.Add(txtDescription);
            Controls.Add(label9);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(label8);
            Controls.Add(numDiscount);
            Controls.Add(label7);
            Controls.Add(numQuantity);
            Controls.Add(label6);
            Controls.Add(cmbUnit);
            Controls.Add(label5);
            Controls.Add(numPrice);
            Controls.Add(label4);
            Controls.Add(cmbSupplier);
            Controls.Add(cmbManufactory);
            Controls.Add(label3);
            Controls.Add(cmbCategory);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddProduct";
            Text = "Добавление товара";
            Load += AddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDiscount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private ComboBox cmbCategory;
        private Label label3;
        private ComboBox cmbManufactory;
        private ComboBox cmbSupplier;
        private Label label4;
        private NumericUpDown numPrice;
        private Label label5;
        private ComboBox cmbUnit;
        private Label label6;
        private NumericUpDown numQuantity;
        private Label label7;
        private NumericUpDown numDiscount;
        private Label label8;
        private Button btnAdd;
        private Button btnClose;
        private Label label9;
        private TextBox txtDescription;
    }
}