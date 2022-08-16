
namespace AutoShowroom
{
    partial class ClientForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.label1 = new System.Windows.Forms.Label();
            this.TypeVehicle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Brand = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.YearFrom = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.YearTo = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AdminLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(102, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип транспортного засобу:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TypeVehicle
            // 
            this.TypeVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeVehicle.FormattingEnabled = true;
            this.TypeVehicle.Items.AddRange(new object[] {
            "Автомобіль",
            "Мотоцикл"});
            this.TypeVehicle.Location = new System.Drawing.Point(345, 35);
            this.TypeVehicle.Name = "TypeVehicle";
            this.TypeVehicle.Size = new System.Drawing.Size(197, 24);
            this.TypeVehicle.TabIndex = 2;
            this.TypeVehicle.SelectedIndexChanged += new System.EventHandler(this.TypeVehicle_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(271, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Бренд:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Brand
            // 
            this.Brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Brand.FormattingEnabled = true;
            this.Brand.Location = new System.Drawing.Point(345, 70);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(197, 24);
            this.Brand.TabIndex = 4;
            this.Brand.SelectedIndexChanged += new System.EventHandler(this.Brand_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(259, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Модель:";
            // 
            // Model
            // 
            this.Model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Model.FormattingEnabled = true;
            this.Model.Location = new System.Drawing.Point(345, 107);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(197, 24);
            this.Model.TabIndex = 6;
            this.Model.SelectedIndexChanged += new System.EventHandler(this.Model_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(102, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Рік випуску:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(233, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Від:";
            // 
            // YearFrom
            // 
            this.YearFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearFrom.FormattingEnabled = true;
            this.YearFrom.Location = new System.Drawing.Point(281, 145);
            this.YearFrom.Name = "YearFrom";
            this.YearFrom.Size = new System.Drawing.Size(83, 24);
            this.YearFrom.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(408, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "До:";
            // 
            // YearTo
            // 
            this.YearTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearTo.FormattingEnabled = true;
            this.YearTo.Location = new System.Drawing.Point(459, 145);
            this.YearTo.Name = "YearTo";
            this.YearTo.Size = new System.Drawing.Size(83, 24);
            this.YearTo.TabIndex = 11;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.Control;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(290, 185);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(166, 54);
            this.SearchButton.TabIndex = 14;
            this.SearchButton.Text = "Пошук";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AdminLabel
            // 
            this.AdminLabel.AutoSize = true;
            this.AdminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminLabel.Location = new System.Drawing.Point(271, 242);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(208, 20);
            this.AdminLabel.TabIndex = 15;
            this.AdminLabel.TabStop = true;
            this.AdminLabel.Text = "Панель адміністратора";
            this.AdminLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AdminLabel_LinkClicked);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(755, 453);
            this.Controls.Add(this.AdminLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.YearTo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.YearFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TypeVehicle);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TypeVehicle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Brand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Model;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox YearFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox YearTo;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.LinkLabel AdminLabel;
    }
}

