
namespace AutoShowroom
{
    partial class ListOfVehiclesForm
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
            this.VehicleListView = new System.Windows.Forms.ListView();
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Brand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProdYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddVehicleButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VehicleListView
            // 
            this.VehicleListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Type,
            this.Brand,
            this.Model,
            this.ProdYear,
            this.Price});
            this.VehicleListView.FullRowSelect = true;
            this.VehicleListView.GridLines = true;
            this.VehicleListView.HideSelection = false;
            this.VehicleListView.Location = new System.Drawing.Point(12, 12);
            this.VehicleListView.Name = "VehicleListView";
            this.VehicleListView.Size = new System.Drawing.Size(776, 365);
            this.VehicleListView.TabIndex = 0;
            this.VehicleListView.UseCompatibleStateImageBehavior = false;
            this.VehicleListView.View = System.Windows.Forms.View.Details;
            // 
            // Type
            // 
            this.Type.Text = "Тип";
            this.Type.Width = 83;
            // 
            // Brand
            // 
            this.Brand.Text = "Бренд";
            this.Brand.Width = 91;
            // 
            // Model
            // 
            this.Model.Text = "Модель";
            this.Model.Width = 102;
            // 
            // ProdYear
            // 
            this.ProdYear.Text = "Рік виготовлення";
            this.ProdYear.Width = 131;
            // 
            // Price
            // 
            this.Price.Text = "Ціна";
            this.Price.Width = 89;
            // 
            // AddVehicleButton
            // 
            this.AddVehicleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddVehicleButton.Location = new System.Drawing.Point(613, 383);
            this.AddVehicleButton.Name = "AddVehicleButton";
            this.AddVehicleButton.Size = new System.Drawing.Size(130, 55);
            this.AddVehicleButton.TabIndex = 1;
            this.AddVehicleButton.Text = "Додати транспорт";
            this.AddVehicleButton.UseVisualStyleBackColor = true;
            this.AddVehicleButton.Click += new System.EventHandler(this.AddVehicleButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(44, 383);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(130, 55);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Видалити транспорт";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ListOfVehiclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddVehicleButton);
            this.Controls.Add(this.VehicleListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListOfVehiclesForm";
            this.Text = "ListOfVehiclesForm";
            this.Load += new System.EventHandler(this.ListOfVehiclesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView VehicleListView;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Brand;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader ProdYear;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Button AddVehicleButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}