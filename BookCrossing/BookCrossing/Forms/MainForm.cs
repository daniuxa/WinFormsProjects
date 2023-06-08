using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookCrossing.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RulesLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RulesForm form = new RulesForm();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.ShowDialog();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            LogInForm form = new LogInForm();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
