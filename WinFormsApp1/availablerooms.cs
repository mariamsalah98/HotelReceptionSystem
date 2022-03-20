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
    public partial class Available_Rooms : Form
    {
        public Available_Rooms()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Receptionist home_Receptionist = new Home_Receptionist();
            home_Receptionist.Show();
        }

        private void Available_Rooms_Load(object sender, EventArgs e)
        {
            List<int> ava_rooms = Receptionist.Check_Room_avaliability().Select(e => e.RoomNO).ToList();
            for(int i = 0; i < ava_rooms.Count; i++)
            {
                label3.Text += " "+ava_rooms[i]+" ";
            }
        }
    }
}
