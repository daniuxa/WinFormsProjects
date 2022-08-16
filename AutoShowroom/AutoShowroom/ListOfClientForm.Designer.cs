
namespace AutoShowroom
{
    partial class ListOfClientForm
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
            this.ClientListView = new System.Windows.Forms.ListView();
            this.NameClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VisitDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewVehicle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DetailInfoButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientListView
            // 
            this.ClientListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameClient,
            this.Surname,
            this.PhoneNumber,
            this.VisitDate,
            this.ViewVehicle});
            this.ClientListView.FullRowSelect = true;
            this.ClientListView.GridLines = true;
            this.ClientListView.HideSelection = false;
            this.ClientListView.Location = new System.Drawing.Point(12, 12);
            this.ClientListView.Name = "ClientListView";
            this.ClientListView.Size = new System.Drawing.Size(776, 368);
            this.ClientListView.TabIndex = 0;
            this.ClientListView.UseCompatibleStateImageBehavior = false;
            this.ClientListView.View = System.Windows.Forms.View.Details;
            // 
            // NameClient
            // 
            this.NameClient.Text = "Ім\'я";
            this.NameClient.Width = 102;
            // 
            // Surname
            // 
            this.Surname.Text = "Прізвище";
            this.Surname.Width = 127;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Text = "Номер телефону";
            this.PhoneNumber.Width = 135;
            // 
            // VisitDate
            // 
            this.VisitDate.Text = "Дата візиту";
            this.VisitDate.Width = 104;
            // 
            // ViewVehicle
            // 
            this.ViewVehicle.Text = "Бажаний транспорт";
            this.ViewVehicle.Width = 173;
            // 
            // DetailInfoButton
            // 
            this.DetailInfoButton.Location = new System.Drawing.Point(523, 386);
            this.DetailInfoButton.Name = "DetailInfoButton";
            this.DetailInfoButton.Size = new System.Drawing.Size(230, 53);
            this.DetailInfoButton.TabIndex = 1;
            this.DetailInfoButton.Text = "Додаткова інформація про транспорт";
            this.DetailInfoButton.UseVisualStyleBackColor = true;
            this.DetailInfoButton.Click += new System.EventHandler(this.DetailInfoButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(48, 386);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(230, 53);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Видалити клієнта";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ListOfClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.DetailInfoButton);
            this.Controls.Add(this.ClientListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListOfClientForm";
            this.Text = "ListOfClientForm";
            this.Load += new System.EventHandler(this.ListOfClientForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ClientListView;
        private System.Windows.Forms.ColumnHeader NameClient;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.ColumnHeader PhoneNumber;
        private System.Windows.Forms.ColumnHeader VisitDate;
        private System.Windows.Forms.ColumnHeader ViewVehicle;
        private System.Windows.Forms.Button DetailInfoButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}