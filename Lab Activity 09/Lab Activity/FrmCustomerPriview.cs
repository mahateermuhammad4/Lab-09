using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Activity
{
    public partial class FrmCustomerPriview : Form
    {
        public FrmCustomerPriview(string name,string gender,string status,string hobbies ,string countries)
        {

            InitializeComponent();
            label1.Height = 20;
            label2.Height = 20;
            label3.Height = 20;
            label4.Height = 20;
            label5.Height =20;
            label1.Width = 20;
            label2.Width = 20;
            label3.Width = 20;
            label4.Width = 20;
            label5.Width = 20;
            label1.Text ="Name is " + name;
            label2.Text = "country is " + countries;
            label3.Text = "Gender is " + gender;
            label4.Text = "Hobbies is " + hobbies;
            label5.Text = "Status is " + status;
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
        }

        private void FrmCustomerPriview_Load(object sender, EventArgs e)
        {

        }
    }
}
