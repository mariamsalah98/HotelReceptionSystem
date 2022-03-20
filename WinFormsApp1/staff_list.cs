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
    public partial class staff_list : Form
    {
        BindingList<User> staff;
        public staff_list()
        {
            InitializeComponent();
        }
        private void staff_list_Load(object sender, EventArgs e)
        {

            staff = new BindingList<User>(Data.users.Where(e => e.type == Type.R).ToList());
            dataGridView1.DataSource = staff;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
               Manager.Delete_Receptionist_info((int)dataGridView1.SelectedRows[0].Cells[0].Value);
                staff.RemoveAt(dataGridView1.SelectedRows[0].Index);
                
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
            User user = new User() 
            { 
                user_id= int.Parse(nationalid.Text),
                Password= password.Text ,
                Email = email.Text , 
                user_Name = name.Text ,
                shift =int.Parse(shift.Text) ,
               Tel_No = telephone.Text ,
               type = Type.R
            };
            if (Data.users.Select(e => e.user_id).Contains(user.user_id))
            {
                MessageBox.Show("A staff member with this ID already exists");
            }
            else
            {
                staff.Add(user);
                Manager.Add_Receptionist_info(user);
            }      
        }


    }
}
