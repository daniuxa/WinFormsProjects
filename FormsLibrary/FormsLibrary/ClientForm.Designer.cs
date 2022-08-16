
namespace FormsLibrary
{
    partial class ClientForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameMain = new System.Windows.Forms.TextBox();
            this.SearchMain = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Filter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AdminButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListClientButton = new System.Windows.Forms.Button();
            this.ListBookButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть назву книги";
            // 
            // NameMain
            // 
            this.NameMain.Location = new System.Drawing.Point(224, 30);
            this.NameMain.Name = "NameMain";
            this.NameMain.Size = new System.Drawing.Size(175, 22);
            this.NameMain.TabIndex = 1;
            // 
            // SearchMain
            // 
            this.SearchMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchMain.Location = new System.Drawing.Point(425, 28);
            this.SearchMain.Name = "SearchMain";
            this.SearchMain.Size = new System.Drawing.Size(132, 32);
            this.SearchMain.TabIndex = 2;
            this.SearchMain.Text = "Пошук";
            this.SearchMain.UseVisualStyleBackColor = true;
            this.SearchMain.Click += new System.EventHandler(this.SearchMain_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пошук з фільтрами:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Filter
            // 
            this.Filter.Location = new System.Drawing.Point(425, 86);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(132, 32);
            this.Filter.TabIndex = 4;
            this.Filter.Text = "Додати фільтри";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Зайти під профілем адміністратора: ";
            // 
            // AdminButton
            // 
            this.AdminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminButton.Location = new System.Drawing.Point(425, 150);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(132, 32);
            this.AdminButton.TabIndex = 6;
            this.AdminButton.Text = "Адміністратор";
            this.AdminButton.UseVisualStyleBackColor = true;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ListBookButton);
            this.panel1.Controls.Add(this.ListClientButton);
            this.panel1.Location = new System.Drawing.Point(-4, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 249);
            this.panel1.TabIndex = 7;
            // 
            // ListClientButton
            // 
            this.ListClientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListClientButton.Location = new System.Drawing.Point(135, 82);
            this.ListClientButton.Name = "ListClientButton";
            this.ListClientButton.Size = new System.Drawing.Size(132, 54);
            this.ListClientButton.TabIndex = 8;
            this.ListClientButton.Text = "Список клієнтів";
            this.ListClientButton.UseVisualStyleBackColor = true;
            this.ListClientButton.Click += new System.EventHandler(this.ListClientButton_Click);
            // 
            // ListBookButton
            // 
            this.ListBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListBookButton.Location = new System.Drawing.Point(531, 82);
            this.ListBookButton.Name = "ListBookButton";
            this.ListBookButton.Size = new System.Drawing.Size(132, 54);
            this.ListBookButton.TabIndex = 9;
            this.ListBookButton.Text = "Список книг";
            this.ListBookButton.UseVisualStyleBackColor = true;
            this.ListBookButton.Click += new System.EventHandler(this.ListBookButton_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AdminButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchMain);
            this.Controls.Add(this.NameMain);
            this.Controls.Add(this.label1);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameMain;
        private System.Windows.Forms.Button SearchMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ListBookButton;
        private System.Windows.Forms.Button ListClientButton;
    }
}