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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            Type mytype = (comboBox1.SelectedIndex == 1) ? Type.R : Type.M;

            if (User.login(textBox1.Text,textBox2.Text,mytype))
            {
                this.Hide();
                if (mytype==Type.R)
                {
                    Home_Receptionist form = new Home_Receptionist();
                    form.Show();
                }
                else
                {
                    Home_Manager form = new Home_Manager();
                    form.Show();
                }
            }
            else
            {
                label5.Text = "The data You enetered is incorrect";
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EntryPage form = new EntryPage();
            form.Show();
        }
    }
}
