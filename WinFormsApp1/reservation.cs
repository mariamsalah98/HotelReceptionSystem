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
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Receptionist home_Receptionist = new Home_Receptionist();
            home_Receptionist.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(guestid.Text!=null && guestname.Text!=null && guestno.Text!=null && rid.Text!=null && roomnumbers.SelectedItem != null)

            {
                Guest guest = new() { Guest_ID = guestid.Text, Guest_Name = guestname.Text, tele_no = guestno.Text };
                if (!Data.guests.Select(e => e.Guest_ID).ToList().Contains(guest.Guest_ID))
                {
                    Data.guests.Add(guest);
                }
                ReservationClass reserve = new()
                {
                    Reservation_Id = int.Parse(rid.Text),
                    Guest_id = guestid.Text,
                    CheckIn = from_checkin.Value,
                    CheckOut = to_checkout.Value,
                    Room_Number = (int)roomnumbers.SelectedItem,
                    BillNo = null,
                    status = Status.INACTIVE,
                };
                if (Receptionist.Make_Reservation(reserve))
                {
                    const string message = "Reservation was successful !!";
                    const string caption = "Reservation Results";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Information);

                    if (result == DialogResult.OK)
                    {
                        this.Hide();
                        Home_Receptionist home_Receptionist = new Home_Receptionist();
                        home_Receptionist.Show();
                    }
                }
                else
                {
                    MessageBox.Show("This was an existing reservation ID !!");
                }
                    
                
            }
            else
            {
                MessageBox.Show("You need to fill all data !!");
            }
            
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            List<Room> rooms = Receptionist.Check_Room_avaliability().Select(e=>e).ToList();
            for (int i = 0; i < rooms.Count; i++)
            {   
                    roomnumbers.Items.Add(rooms[i].RoomNO);
            }           
        }

        private void roomnumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoomTypes roomtypes = default;
            RoomViews roomviews = default;
            for(int i = 0;i < Data.rooms.Count; i++)
            {
                if(Data.rooms[i].RoomNO == (int)roomnumbers.SelectedItem)
                {
                    roomtypes = Data.rooms[i].Room_Type;
                    roomviews = Data.rooms[i].Room_Views;
                }
            }
            roomtype.SelectedItem=roomtypes;
            roomview.SelectedItem=roomviews;
            roomtype.SelectedText=roomtypes.ToString();
            roomview.SelectedText=roomviews.ToString();
        }
    }
}
