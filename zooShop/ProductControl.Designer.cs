namespace zooShop
{
    partial class ProductControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            pBox = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblName = new Label();
            lblManufactory = new Label();
            lblCategory = new Label();
            lblDescription = new Label();
            lblSupplier = new Label();
            lblPrice = new Label();
            lblUnit = new Label();
            lblQuantity = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            labelDiscount = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pBox).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // pBox
            // 
            pBox.BorderStyle = BorderStyle.FixedSingle;
            pBox.ErrorImage = null;
            pBox.InitialImage = null;
            pBox.Location = new Point(3, 3);
            pBox.Name = "pBox";
            pBox.Size = new Size(214, 177);
            pBox.SizeMode = PictureBoxSizeMode.Zoom;
            pBox.TabIndex = 0;
            pBox.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(lblName);
            flowLayoutPanel1.Controls.Add(lblManufactory);
            flowLayoutPanel1.Controls.Add(lblCategory);
            flowLayoutPanel1.Controls.Add(lblDescription);
            flowLayoutPanel1.Controls.Add(lblSupplier);
            flowLayoutPanel1.Controls.Add(lblPrice);
            flowLayoutPanel1.Controls.Add(lblUnit);
            flowLayoutPanel1.Controls.Add(lblQuantity);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(220, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(512, 177);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 23);
            lblName.TabIndex = 0;
            lblName.Text = "label2";
            // 
            // lblManufactory
            // 
            lblManufactory.AutoSize = true;
            lblManufactory.BackColor = Color.Transparent;
            lblManufactory.Font = new Font("Calibri", 12F);
            lblManufactory.Location = new Point(3, 23);
            lblManufactory.Name = "lblManufactory";
            lblManufactory.Size = new Size(49, 19);
            lblManufactory.TabIndex = 3;
            lblManufactory.Text = "label2";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Transparent;
            lblCategory.Font = new Font("Calibri", 12F);
            lblCategory.Location = new Point(3, 42);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(49, 19);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "label2";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Calibri", 12F);
            lblDescription.Location = new Point(3, 61);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(49, 19);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "label2";
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.BackColor = Color.Transparent;
            lblSupplier.Font = new Font("Calibri", 12F);
            lblSupplier.Location = new Point(3, 80);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(49, 19);
            lblSupplier.TabIndex = 4;
            lblSupplier.Text = "label2";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font = new Font("Calibri", 12F);
            lblPrice.Location = new Point(3, 99);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(49, 19);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "label2";
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.BackColor = Color.Transparent;
            lblUnit.Font = new Font("Calibri", 12F);
            lblUnit.Location = new Point(3, 118);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(49, 19);
            lblUnit.TabIndex = 6;
            lblUnit.Text = "label2";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.Transparent;
            lblQuantity.Font = new Font("Calibri", 12F);
            lblQuantity.Location = new Point(3, 137);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(49, 19);
            lblQuantity.TabIndex = 7;
            lblQuantity.Text = "label2";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel2.Controls.Add(labelDiscount);
            flowLayoutPanel2.Location = new Point(734, 4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(149, 90);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // labelDiscount
            // 
            labelDiscount.AutoSize = true;
            labelDiscount.BackColor = Color.Transparent;
            labelDiscount.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDiscount.Location = new Point(3, 0);
            labelDiscount.Name = "labelDiscount";
            labelDiscount.Size = new Size(74, 29);
            labelDiscount.TabIndex = 0;
            labelDiscount.Text = "label1";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(235, 15, 15);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(734, 94);
            button1.Name = "button1";
            button1.Size = new Size(149, 41);
            button1.TabIndex = 3;
            button1.Text = "Редактировать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(235, 15, 15);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(734, 141);
            button2.Name = "button2";
            button2.Size = new Size(149, 39);
            button2.TabIndex = 4;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ProductControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pBox);
            Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "ProductControl";
            Size = new Size(886, 183);
            Load += ProductControl_Load;
            ((System.ComponentModel.ISupportInitialize)pBox).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label labelDiscount;
        private Button button1;
        private Button button2;
        private Label lblName;
        private Label lblCategory;
        private Label lblDescription;
        private Label lblManufactory;
        private Label lblSupplier;
        private Label lblPrice;
        private Label lblUnit;
        private Label lblQuantity;
    }
}
