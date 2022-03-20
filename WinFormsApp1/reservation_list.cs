using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class reservation_list : Form
    {
        BindingList<ReservationClass> grid_reservations;
        public reservation_list()
        {
            InitializeComponent();
           

        }  


        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Receptionist home_Receptionist = new Home_Receptionist();
            home_Receptionist.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                grid_reservations .RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((Status)Enum.Parse(typeof(Status), dataGridView1.SelectedRows[0].Cells[6].Value.ToString()) == Status.CHECKEDIN)
            {
                dataGridView1.SelectedRows[0].Cells[6].Value = Status.CHECKEDOUT;
                Receptionist.Checkout((string)dataGridView1.SelectedRows[0].Cells[1].Value);
                this.Hide();
                Billform billform = new Billform((int)dataGridView1.SelectedRows[0].Cells[0].Value);
                billform.Show();
            }
            else
            {
                MessageBox.Show("You are not checked in to check out !!");
            }    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if((Status)Enum.Parse(typeof(Status),dataGridView1.SelectedRows[0].Cells[6].Value.ToString() )== Status.INACTIVE)
            {
                dataGridView1.SelectedRows[0].Cells[6].Value = Status.CHECKEDIN;
                Receptionist.Checkin((string)dataGridView1.SelectedRows[0].Cells[1].Value);
            }
            else
            {
                MessageBox.Show("You have alraedy checked in !");
            }
           

        }

        private void reservation_list_Load(object sender, EventArgs e)
        {
            grid_reservations = new BindingList<ReservationClass>(Data.reservations);
            dataGridView1.DataSource = grid_reservations;
            
        }

    }
}
