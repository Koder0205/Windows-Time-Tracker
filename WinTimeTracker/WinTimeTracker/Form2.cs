using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTimeTracker
{
    public partial class ProgramSelect : Form
    {
        public ProgramSelect()
        {
            InitializeComponent();
            // 각 콤보박스에 데이타를 초기화
            comboBox1.Items.Insert(0, "==프로그램을 선택해 주세요==");
            comboBox2.Items.Insert(0, "==태그를 선택해 주세요==");
            // 처음 선택값 지정. 첫째 아이템 선택
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProgramSelect_Load(object sender, EventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
