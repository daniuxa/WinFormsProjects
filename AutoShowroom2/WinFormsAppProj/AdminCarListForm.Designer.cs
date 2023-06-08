﻿
namespace WinFormsAppProj
{
    partial class AdminCarListForm
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
            this.TopBorder = new System.Windows.Forms.Panel();
            this.CloseButtn = new System.Windows.Forms.Button();
            this.CarListView = new System.Windows.Forms.ListView();
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Brand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProdYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeEngine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Power = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Volume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddCarButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ExtraInfoButton = new System.Windows.Forms.Button();
            this.TopBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBorder
            // 
            this.TopBorder.BackColor = System.Drawing.Color.Silver;
            this.TopBorder.Controls.Add(this.CloseButtn);
            this.TopBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorder.Location = new System.Drawing.Point(0, 0);
            this.TopBorder.Name = "TopBorder";
            this.TopBorder.Size = new System.Drawing.Size(800, 28);
            this.TopBorder.TabIndex = 17;
            this.TopBorder.Paint += new System.Windows.Forms.PaintEventHandler(this.TopBorder_Paint);
            this.TopBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseDown);
            this.TopBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseMove);
            // 
            // CloseButtn
            // 
            this.CloseButtn.BackColor = System.Drawing.Color.Red;
            this.CloseButtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseButtn.FlatAppearance.BorderSize = 0;
            this.CloseButtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.CloseButtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseButtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseButtn.Location = new System.Drawing.Point(772, 3);
            this.CloseButtn.Name = "CloseButtn";
            this.CloseButtn.Size = new System.Drawing.Size(25, 25);
            this.CloseButtn.TabIndex = 10;
            this.CloseButtn.Text = "X";
            this.CloseButtn.UseVisualStyleBackColor = false;
            this.CloseButtn.Click += new System.EventHandler(this.CloseButtn_Click);
            // 
            // CarListView
            // 
            this.CarListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Type,
            this.Brand,
            this.Model,
            this.ProdYear,
            this.Price,
            this.TypeEngine,
            this.Power,
            this.Volume});
            this.CarListView.FullRowSelect = true;
            this.CarListView.GridLines = true;
            this.CarListView.HideSelection = false;
            this.CarListView.Location = new System.Drawing.Point(12, 34);
            this.CarListView.Name = "CarListView";
            this.CarListView.Size = new System.Drawing.Size(776, 357);
            this.CarListView.TabIndex = 18;
            this.CarListView.UseCompatibleStateImageBehavior = false;
            this.CarListView.View = System.Windows.Forms.View.Details;
            // 
            // Type
            // 
            this.Type.Text = "Тип";
            this.Type.Width = 75;
            // 
            // Brand
            // 
            this.Brand.Text = "Бренд";
            this.Brand.Width = 93;
            // 
            // Model
            // 
            this.Model.Text = "Модель";
            this.Model.Width = 96;
            // 
            // ProdYear
            // 
            this.ProdYear.Text = "Рік виробництва";
            this.ProdYear.Width = 125;
            // 
            // Price
            // 
            this.Price.Text = "Ціна";
            this.Price.Width = 79;
            // 
            // TypeEngine
            // 
            this.TypeEngine.Text = "Тип двигуна";
            this.TypeEngine.Width = 115;
            // 
            // Power
            // 
            this.Power.Text = "Потужність";
            this.Power.Width = 94;
            // 
            // Volume
            // 
            this.Volume.Text = "Об\'єм двигуна";
            this.Volume.Width = 61;
            // 
            // AddCarButton
            // 
            this.AddCarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCarButton.Location = new System.Drawing.Point(644, 397);
            this.AddCarButton.Name = "AddCarButton";
            this.AddCarButton.Size = new System.Drawing.Size(144, 41);
            this.AddCarButton.TabIndex = 19;
            this.AddCarButton.Text = "Додати авто";
            this.AddCarButton.UseVisualStyleBackColor = true;
            this.AddCarButton.Click += new System.EventHandler(this.AddCarButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(12, 397);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(166, 41);
            this.DeleteButton.TabIndex = 22;
            this.DeleteButton.Text = "Видалити авто";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ExtraInfoButton
            // 
            this.ExtraInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExtraInfoButton.Location = new System.Drawing.Point(288, 402);
            this.ExtraInfoButton.Name = "ExtraInfoButton";
            this.ExtraInfoButton.Size = new System.Drawing.Size(231, 36);
            this.ExtraInfoButton.TabIndex = 23;
            this.ExtraInfoButton.Text = "Додаткова інформація";
            this.ExtraInfoButton.UseVisualStyleBackColor = true;
            this.ExtraInfoButton.Click += new System.EventHandler(this.ExtraInfoButton_Click);
            // 
            // AdminCarListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExtraInfoButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddCarButton);
            this.Controls.Add(this.CarListView);
            this.Controls.Add(this.TopBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminCarListForm";
            this.Text = "AdminCarListForm";
            this.Load += new System.EventHandler(this.AdminCarListForm_Load);
            this.TopBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBorder;
        private System.Windows.Forms.Button CloseButtn;
        private System.Windows.Forms.ListView CarListView;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Brand;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader ProdYear;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader TypeEngine;
        private System.Windows.Forms.ColumnHeader Power;
        private System.Windows.Forms.ColumnHeader Volume;
        private System.Windows.Forms.Button AddCarButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ExtraInfoButton;
    }
}