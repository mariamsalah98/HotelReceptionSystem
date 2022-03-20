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
    public partial class Billform : Form
    {
        int reservation_id;
        public Billform(int x)
        {
            InitializeComponent();
             reservation_id = x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            reservation_list reservation_List = new reservation_list();
            reservation_List.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            const string message = "Paid Successfull!!";
            const string caption = "Bill";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                this.Hide();
                reservation_list reservation_List = new reservation_list();
                reservation_List.Show();
            }
        }

        private void Billform_Load(object sender, EventArgs e)
        {
            label1.Text = Receptionist.Generate_Bill(reservation_id);
        }
    }
}
