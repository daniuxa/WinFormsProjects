
namespace AutoShowroom
{
    partial class SuccessfulOrder
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
            this.Surname = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.VisitDate = new System.Windows.Forms.Label();
            this.OKButtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname.Location = new System.Drawing.Point(272, 71);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(147, 20);
            this.Surname.TabIndex = 32;
            this.Surname.Text = "Ваше прізвище: ";
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerName.Location = new System.Drawing.Point(272, 38);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(100, 20);
            this.CustomerName.TabIndex = 38;
            this.CustomerName.Text = "Ваше ім\'я: ";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Phone.Location = new System.Drawing.Point(272, 104);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(206, 20);
            this.Phone.TabIndex = 34;
            this.Phone.Text = "Ваш номер телефону:  ";
            // 
            // VisitDate
            // 
            this.VisitDate.AutoSize = true;
            this.VisitDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisitDate.Location = new System.Drawing.Point(272, 139);
            this.VisitDate.Name = "VisitDate";
            this.VisitDate.Size = new System.Drawing.Size(116, 20);
            this.VisitDate.TabIndex = 35;
            this.VisitDate.Text = "Дату візиту: ";
            // 
            // OKButtn
            // 
            this.OKButtn.Location = new System.Drawing.Point(342, 300);
            this.OKButtn.Name = "OKButtn";
            this.OKButtn.Size = new System.Drawing.Size(94, 32);
            this.OKButtn.TabIndex = 37;
            this.OKButtn.Text = "ОК";
            this.OKButtn.UseVisualStyleBackColor = true;
            this.OKButtn.Click += new System.EventHandler(this.OKButtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(272, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 96);
            this.label3.TabIndex = 36;
            this.label3.Text = "Замовлення успішно оформлене\r\n\r\nЗараз з вами зв\'яжеться наш менеджер\r\nдля уточнен" +
    "ня деталей";
            // 
            // SuccessfulOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 400);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.OKButtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VisitDate);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Surname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SuccessfulOrder";
            this.Text = "SuccessfulOrder";
            this.Load += new System.EventHandler(this.SuccessfulOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label VisitDate;
        private System.Windows.Forms.Button OKButtn;
        private System.Windows.Forms.Label label3;
    }
}