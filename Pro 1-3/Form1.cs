using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro_1_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        private void trkAge_Scroll_1(object sender, EventArgs e)
        {


            lblAge2.Text = trkAge.Value.ToString();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            int age = Convert.ToInt32(lblAge2.Text);

            double tall = Convert.ToDouble(txtHeight.Text);

            
       
            

            lblOuput.Text = "Hello " + name;

            lblOutput2.Text = "You are " + (82 - age)  + " years below the average life expectancy";

            lblOutput3.Text = "You are " + Math.Round((2.72 - tall),2) + " metres smaller than the tallest person";

        }
    }
}