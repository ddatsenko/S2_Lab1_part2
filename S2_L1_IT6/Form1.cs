using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S2_L1_IT6
{
    public partial class Form1 : Form
    {
        List<Button> buttons;
        public Form1()
        {
            InitializeComponent();
            buttons = new List<Button>();
            buttons.AddRange(new Button[5] 
            { 
                button1, button2, button3, button4, button5 
            });
            button1.Click += button1_Click;
            button2.Click += button1_Click;
            button3.Click += button1_Click;
            button4.Click += button1_Click;
            button5.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rndm = new Random(DateTime.Now.Millisecond);
            Button bttn = buttons[rndm.Next(buttons.Count)];
            bttn.Visible = !bttn.Visible;
        }
    }
}
