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
    public partial class ViewFeedback : Form
    {
        public ViewFeedback()
        {
            InitializeComponent();
        }

        private void ViewFeedback_Load(object sender, EventArgs e)
        {
            BindingList<Feedback_implemenet> grid_feedback = new BindingList<Feedback_implemenet>(Data.feedbacks);

            dataGridView1.DataSource = grid_feedback;
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home_Manager h_manager = new Home_Manager();
            h_manager.Show();
        }
    }
}
