using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            question1Btn.BackColor = Color.White; 
         

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void question1Btn_Enter(object sender, EventArgs e)
        {
           

        }

        private void answer1_2Btn_CheckedChanged(object sender, EventArgs e)
        {
            if (answer1_2Btn.Checked == true)
            {
                question1Btn.BackColor = Color.Green;
            }
            else
            {
                question1Btn.BackColor = Color.Red;
            }

        }

        private void answer2_1Btn_CheckedChanged(object sender, EventArgs e)
        {
            if (answer2_1Btn.Checked == true)
            {
                question2Btn.BackColor = Color.Green;
            }
            else
            {
                question2Btn.BackColor = Color.Red;
            }
        }

        private void answer3_3Btn_CheckedChanged(object sender, EventArgs e)
        {
            if (answer3_3Btn.Checked == true)
            {
                question3Btn.BackColor = Color.Green;
            }
            else
            {
                question3Btn.BackColor = Color.Red;
            }
        }

        private void answer1_1Btn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void answer4_2Btn_CheckedChanged(object sender, EventArgs e)
        {
            if (answer4_2Btn.Checked == true)
            {
                question4Btn.BackColor = Color.Green;
            }
            else
            {
                question4Btn.BackColor = Color.Red;
            }
        }

        private void answer5_2Btn_CheckedChanged(object sender, EventArgs e)
        {
            if (answer5_2Btn.Checked == true)
            {
                question5Btn.BackColor = Color.Green;
            }
            else
            {
                question5Btn.BackColor = Color.Red;
            }
        }
    }
}
