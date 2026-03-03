namespace zooShop
{
    partial class OrderControl1
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
            lblOrderNumber = new Label();
            lblPickupPoint = new Label();
            lblClient = new Label();
            lblCode = new Label();
            lblStatus = new Label();
            lblDelivery = new Label();
            lblDateOrder = new Label();
            btnRedact = new Button();
            dtnDelete = new Button();
            SuspendLayout();
            // 
            // lblOrderNumber
            // 
            lblOrderNumber.AutoSize = true;
            lblOrderNumber.Location = new Point(149, 79);
            lblOrderNumber.Name = "lblOrderNumber";
            lblOrderNumber.Size = new Size(49, 19);
            lblOrderNumber.TabIndex = 0;
            lblOrderNumber.Text = "label1";
            // 
            // lblPickupPoint
            // 
            lblPickupPoint.AutoSize = true;
            lblPickupPoint.Location = new Point(149, 41);
            lblPickupPoint.Name = "lblPickupPoint";
            lblPickupPoint.Size = new Size(49, 19);
            lblPickupPoint.TabIndex = 3;
            lblPickupPoint.Text = "label1";
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.Location = new Point(149, 9);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(49, 19);
            lblClient.TabIndex = 7;
            lblClient.Text = "label2";
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new Point(3, 9);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(49, 19);
            lblCode.TabIndex = 8;
            lblCode.Text = "label2";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Calibri", 12F);
            lblStatus.Location = new Point(3, 41);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 19);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "label2";
            // 
            // lblDelivery
            // 
            lblDelivery.AutoSize = true;
            lblDelivery.Font = new Font("Calibri", 12F);
            lblDelivery.Location = new Point(3, 114);
            lblDelivery.Name = "lblDelivery";
            lblDelivery.Size = new Size(49, 19);
            lblDelivery.TabIndex = 11;
            lblDelivery.Text = "label2";
            lblDelivery.Click += label2_Click;
            // 
            // lblDateOrder
            // 
            lblDateOrder.AutoSize = true;
            lblDateOrder.Font = new Font("Calibri", 12F);
            lblDateOrder.Location = new Point(3, 79);
            lblDateOrder.Name = "lblDateOrder";
            lblDateOrder.Size = new Size(49, 19);
            lblDateOrder.TabIndex = 10;
            lblDateOrder.Text = "label2";
            // 
            // btnRedact
            // 
            btnRedact.BackColor = Color.FromArgb(235, 15, 15);
            btnRedact.FlatAppearance.BorderSize = 0;
            btnRedact.FlatStyle = FlatStyle.Flat;
            btnRedact.Location = new Point(277, 41);
            btnRedact.Name = "btnRedact";
            btnRedact.Size = new Size(164, 46);
            btnRedact.TabIndex = 12;
            btnRedact.Text = "Редактировать";
            btnRedact.UseVisualStyleBackColor = false;
            btnRedact.Click += btnRedact_Click;
            // 
            // dtnDelete
            // 
            dtnDelete.BackColor = Color.FromArgb(235, 15, 15);
            dtnDelete.FlatAppearance.BorderSize = 0;
            dtnDelete.FlatStyle = FlatStyle.Flat;
            dtnDelete.Location = new Point(277, 92);
            dtnDelete.Name = "dtnDelete";
            dtnDelete.Size = new Size(164, 46);
            dtnDelete.TabIndex = 13;
            dtnDelete.Text = "Удалить";
            dtnDelete.UseVisualStyleBackColor = false;
            dtnDelete.Click += dtnDelete_Click;
            // 
            // OrderControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dtnDelete);
            Controls.Add(lblClient);
            Controls.Add(lblPickupPoint);
            Controls.Add(lblCode);
            Controls.Add(lblOrderNumber);
            Controls.Add(lblStatus);
            Controls.Add(lblDateOrder);
            Controls.Add(btnRedact);
            Controls.Add(lblDelivery);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrderControl1";
            Size = new Size(441, 138);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrderNumber;
        private Label lblPickupPoint;
        private Label lblClient;
        private Label lblCode;
        private Label lblStatus;
        private Label lblDelivery;
        private Label lblDateOrder;
        private Button btnRedact;
        private Button dtnDelete;
    }
}
