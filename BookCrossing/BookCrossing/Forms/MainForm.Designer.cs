namespace BookCrossing.Forms
{
    partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.RulesLabel = new System.Windows.Forms.LinkLabel();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.LogInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkKhaki;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(188, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вас вітає всесвітня бібліотека BookCrossing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkKhaki;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(121, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(729, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "«Людина з гарною книгою в руках ніколи не може бути самотньою» К. Гольдоні";
            // 
            // RulesLabel
            // 
            this.RulesLabel.AutoSize = true;
            this.RulesLabel.BackColor = System.Drawing.Color.DarkKhaki;
            this.RulesLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RulesLabel.Location = new System.Drawing.Point(316, 177);
            this.RulesLabel.Name = "RulesLabel";
            this.RulesLabel.Size = new System.Drawing.Size(328, 24);
            this.RulesLabel.TabIndex = 2;
            this.RulesLabel.TabStop = true;
            this.RulesLabel.Text = "Ознайомитися з правилами сервісу";
            this.RulesLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RulesLabel_LinkClicked);
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterButton.Location = new System.Drawing.Point(194, 386);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(200, 75);
            this.RegisterButton.TabIndex = 3;
            this.RegisterButton.Text = "Зареєструватися";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // LogInButton
            // 
            this.LogInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.LogInButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogInButton.Location = new System.Drawing.Point(604, 386);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(200, 75);
            this.LogInButton.TabIndex = 4;
            this.LogInButton.Text = "Увійти в аккаунт";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookCrossing.Properties.Resources._1614800883_88_p_fon_dlya_prezentatsii_knigi_115;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 571);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.RulesLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel RulesLabel;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button LogInButton;
    }
}