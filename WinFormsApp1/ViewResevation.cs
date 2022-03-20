using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ViewResevation : Form
    {
        public ViewResevation()
        {
            InitializeComponent();
        }

        private void ViewResevation_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Data.reservations;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Manager home_Manager = new Home_Manager();
            home_Manager.Show();
        }
    }
}
