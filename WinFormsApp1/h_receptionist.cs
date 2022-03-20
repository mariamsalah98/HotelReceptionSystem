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
    public partial class Home_Receptionist : Form
    {
        public Home_Receptionist()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Available_Rooms available_Rooms = new Available_Rooms();
            available_Rooms.Show();
        }



        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reservation reservation = new Reservation();    
            reservation.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            reservation_list reservation_List = new reservation_list();
            reservation_List.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Feedback feedback = new Feedback();
            feedback.Show();
        }
    }
}
