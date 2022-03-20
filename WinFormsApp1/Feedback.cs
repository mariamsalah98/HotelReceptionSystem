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
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Receptionist.Accept_Customer_Feedback(textBox2.Text, richTextBox1.Text))
            {
                const string message = "Saved Feedback Successfull!!";
                const string caption = "Feedback";
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
                MessageBox.Show("You need to enter an existent ID !!");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Receptionist home_Receptionist = new Home_Receptionist();
            home_Receptionist.Show();
        }
    }
}
