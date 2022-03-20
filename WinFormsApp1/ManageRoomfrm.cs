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
    public partial class ManageRoomfrm : Form
    {
        BindingList<Room> grid_rooms;
        public ManageRoomfrm()
        {
            InitializeComponent();
        }

        private void ManageRoomfrm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Data.rooms;
            foreach (string name in Enum.GetNames(typeof(RoomTypes)))
            {
                RoomTypeCB.Items.Add(name.ToString());
            }
            foreach (string name in Enum.GetNames(typeof(RoomViews)))
            {
                RoomViewsCB.Items.Add(name.ToString());
            }
            for (int i = 0; i < Data.rooms.Count; i++)
            {
                RoomUpdatCB.Items.Add(Data.rooms[i].RoomNO.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Manager home_Manager = new Home_Manager();
            home_Manager.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            grid_rooms = new BindingList<Room>(Data.rooms);
            dataGridView1.DataSource = grid_rooms;
            Room newRoom = new(int.Parse(RoomNoTB.Text), int.Parse(RoomPriceTB.Text), (RoomTypes)RoomTypeCB.SelectedIndex, (RoomViews)RoomViewsCB.SelectedIndex);
            Manager.AddRoom(newRoom);


            const string message = "Adding Room was successful !!";
            const string caption = "Adding Results";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                this.Hide();
                ManageRoomfrm manageRoomfrm = new ManageRoomfrm();
                manageRoomfrm.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager.UpdateRoom(Convert.ToInt32(RoomUpdatCB.SelectedItem), int.Parse(NewPriceCB.Text));

            const string message = "updating Room was successful !!";
            const string caption = "Updating Results";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                dataGridView1.DataSource = grid_rooms;
                dataGridView1.Update();
                this.Hide();
                ManageRoomfrm manageRoomfrm = new ManageRoomfrm();
                manageRoomfrm.Show();
            }
        }


    }
}

