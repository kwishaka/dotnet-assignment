using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2
{
    public partial class choose : Form
    {
        public choose()
        {
            InitializeComponent();
        }

        private void bicycleButton_Click(object sender, EventArgs e)
        {
            OpenServiceForm(new bycle());
        }

        private void mechanicButton_Click(object sender, EventArgs e)
        {
            OpenServiceForm(new mashloom());
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenServiceForm(Form serviceForm)
        {
            Hide();
            using (serviceForm)
            {
                serviceForm.ShowDialog(this);
            }
            Show();
        }
    }
}
