namespace zooShop
{
    partial class AddEdiOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEdiOrderForm));
            label1 = new Label();
            cmbStatus = new ComboBox();
            label2 = new Label();
            dtpDelivery = new DateTimePicker();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(26, 46);
            label1.Name = "label1";
            label1.Size = new Size(64, 26);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = Color.FromArgb(120, 219, 226);
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(26, 117);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(206, 27);
            cmbStatus.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Location = new Point(26, 95);
            label2.Name = "label2";
            label2.Size = new Size(105, 19);
            label2.TabIndex = 2;
            label2.Text = "Статус заказа:";
            // 
            // dtpDelivery
            // 
            dtpDelivery.CalendarMonthBackground = Color.FromArgb(120, 219, 226);
            dtpDelivery.Location = new Point(26, 180);
            dtpDelivery.Name = "dtpDelivery";
            dtpDelivery.Size = new Size(206, 27);
            dtpDelivery.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 158);
            label3.Name = "label3";
            label3.Size = new Size(111, 19);
            label3.TabIndex = 4;
            label3.Text = "Дата доставки:";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(120, 219, 226);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(26, 249);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(206, 27);
            comboBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 227);
            label4.Name = "label4";
            label4.Size = new Size(109, 19);
            label4.TabIndex = 6;
            label4.Text = "Пункт выдачи:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(235, 15, 15);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(26, 329);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(206, 36);
            btnSave.TabIndex = 7;
            btnSave.Text = "Добавить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // AddEdiOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(255, 390);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(dtpDelivery);
            Controls.Add(label2);
            Controls.Add(cmbStatus);
            Controls.Add(label1);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddEdiOrderForm";
            Text = "Добавление";
            Load += AddEdiOrderForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbStatus;
        private Label label2;
        private DateTimePicker dtpDelivery;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private Button btnSave;
    }
}