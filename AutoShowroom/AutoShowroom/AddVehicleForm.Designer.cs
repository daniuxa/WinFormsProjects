
namespace AutoShowroom
{
    partial class AddVehicleForm
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
            this.Type = new System.Windows.Forms.Label();
            this.Brand = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.ProdYear = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.ExtraFieldText = new System.Windows.Forms.Label();
            this.BrandComboBox = new System.Windows.Forms.ComboBox();
            this.ModelComboBox = new System.Windows.Forms.ComboBox();
            this.ProdYearComboBox = new System.Windows.Forms.ComboBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.ExtraComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Type
            // 
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Type.Location = new System.Drawing.Point(215, 34);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(100, 23);
            this.Type.TabIndex = 0;
            this.Type.Text = "Тип";
            // 
            // Brand
            // 
            this.Brand.AutoSize = true;
            this.Brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Brand.Location = new System.Drawing.Point(215, 66);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(63, 20);
            this.Brand.TabIndex = 1;
            this.Brand.Text = "Бренд";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Model.Location = new System.Drawing.Point(215, 97);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(75, 20);
            this.Model.TabIndex = 2;
            this.Model.Text = "Модель";
            // 
            // ProdYear
            // 
            this.ProdYear.AutoSize = true;
            this.ProdYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProdYear.Location = new System.Drawing.Point(215, 130);
            this.ProdYear.Name = "ProdYear";
            this.ProdYear.Size = new System.Drawing.Size(102, 20);
            this.ProdYear.TabIndex = 3;
            this.ProdYear.Text = "Рік випуску";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price.Location = new System.Drawing.Point(215, 159);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(46, 20);
            this.Price.TabIndex = 4;
            this.Price.Text = "Ціна";
            // 
            // ExtraFieldText
            // 
            this.ExtraFieldText.AutoSize = true;
            this.ExtraFieldText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExtraFieldText.Location = new System.Drawing.Point(215, 190);
            this.ExtraFieldText.Name = "ExtraFieldText";
            this.ExtraFieldText.Size = new System.Drawing.Size(148, 20);
            this.ExtraFieldText.TabIndex = 5;
            this.ExtraFieldText.Text = "Додаткове поле";
            // 
            // BrandComboBox
            // 
            this.BrandComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BrandComboBox.FormattingEnabled = true;
            this.BrandComboBox.Location = new System.Drawing.Point(392, 62);
            this.BrandComboBox.Name = "BrandComboBox";
            this.BrandComboBox.Size = new System.Drawing.Size(121, 24);
            this.BrandComboBox.TabIndex = 7;
            this.BrandComboBox.SelectedIndexChanged += new System.EventHandler(this.BrandComboBox_SelectedIndexChanged);
            // 
            // ModelComboBox
            // 
            this.ModelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModelComboBox.FormattingEnabled = true;
            this.ModelComboBox.Location = new System.Drawing.Point(392, 93);
            this.ModelComboBox.Name = "ModelComboBox";
            this.ModelComboBox.Size = new System.Drawing.Size(121, 24);
            this.ModelComboBox.TabIndex = 8;
            // 
            // ProdYearComboBox
            // 
            this.ProdYearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProdYearComboBox.FormattingEnabled = true;
            this.ProdYearComboBox.Location = new System.Drawing.Point(392, 126);
            this.ProdYearComboBox.Name = "ProdYearComboBox";
            this.ProdYearComboBox.Size = new System.Drawing.Size(121, 24);
            this.ProdYearComboBox.TabIndex = 9;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(392, 156);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(121, 22);
            this.PriceTextBox.TabIndex = 10;
            // 
            // ExtraComboBox
            // 
            this.ExtraComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExtraComboBox.FormattingEnabled = true;
            this.ExtraComboBox.Location = new System.Drawing.Point(392, 186);
            this.ExtraComboBox.Name = "ExtraComboBox";
            this.ExtraComboBox.Size = new System.Drawing.Size(121, 24);
            this.ExtraComboBox.TabIndex = 11;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(321, 233);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(92, 38);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Додати";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Автомобіль",
            "Мотоцикл"});
            this.TypeComboBox.Location = new System.Drawing.Point(392, 34);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.TypeComboBox.TabIndex = 13;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged_1);
            // 
            // AddVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ExtraComboBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.ProdYearComboBox);
            this.Controls.Add(this.ModelComboBox);
            this.Controls.Add(this.BrandComboBox);
            this.Controls.Add(this.ExtraFieldText);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.ProdYear);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.Type);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddVehicleForm";
            this.Text = "AddVehicleForm";
            this.Load += new System.EventHandler(this.AddVehicleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Brand;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label ProdYear;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label ExtraFieldText;
        private System.Windows.Forms.ComboBox BrandComboBox;
        private System.Windows.Forms.ComboBox ModelComboBox;
        private System.Windows.Forms.ComboBox ProdYearComboBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.ComboBox ExtraComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox TypeComboBox;
    }
}