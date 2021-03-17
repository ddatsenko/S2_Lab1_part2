using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace S2_L1_dentist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") 
            { 
                MessageBox.Show("Please enter the specified information."); 
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false && checkBox6.Checked == false)
            { 
                MessageBox.Show("Please select the needed services.");
            }
            int calc = 0;
            if (checkBox1.Checked == true) calc += 5;
            if (checkBox2.Checked == true) calc += 10;
            if (checkBox3.Checked == true) calc += 15;
            if (checkBox4.Checked == true) calc += 20;
            if (checkBox5.Checked == true) calc += 25;
            if (checkBox6.Checked == true) calc += 30;

            label2.Text += calc;
        }
    }
}
