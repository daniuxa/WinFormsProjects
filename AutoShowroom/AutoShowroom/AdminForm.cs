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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void VehicleButton_Click(object sender, EventArgs e)
        {
            ListOfVehiclesForm form = new ListOfVehiclesForm();
            form.ShowDialog();
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            ListOfClientForm form = new ListOfClientForm();
            form.ShowDialog();
        }
    }
}
