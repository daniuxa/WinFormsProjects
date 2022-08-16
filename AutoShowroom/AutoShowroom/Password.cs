using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoShowroom
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "1234")
            {
                this.Visible = false;
                AdminForm form = new AdminForm();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неправильно введений пароль");
            }
        }
    }
}
