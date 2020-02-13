using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Time_Tracker
{
    public partial class Windows_Time_Tracker : Form
    {
        public Windows_Time_Tracker()
        {
            InitializeComponent();
        }

        private void Windows_Time_Tracker_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.BringToFront();
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            else
                panel1.Visible = true;
        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MenuIconPanel_Paint(object sender, PaintEventArgs e)
        {
            


        }
    }
}
