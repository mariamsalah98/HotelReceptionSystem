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
    public partial class Home_Manager : Form
    {
        public Home_Manager()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            staff_list staff_List = new staff_list();
            staff_List.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewResevation reservation_List = new ViewResevation();
            reservation_List.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewFeedback viewFeedback = new ViewFeedback();
            viewFeedback.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageRoomfrm manageRoomfrm = new ManageRoomfrm();
            manageRoomfrm.Show();
        }
    }
}
