using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label7.Visible = false;
        }
        private string Answer1Right = "arpanet";
        private string Answer5Right = "Star-shaped";
        private string user1;
        private string user5;
        private System.DateTime rightDate = new System.DateTime(1970, 1, 1, 0, 0, 0);
        private System.DateTime user6 = new DateTime();
        int points = 0;
        int wrong = 0;

        private void Delete_Click(object sender, EventArgs e)
        {
            Answer1.Text = "";
            Answer2R1.Checked = Answer2R2.Checked = Answer2R3.Checked = false;
            IP1.Checked = IP2.Checked = IP3.Checked = IP4.Checked = false;
            Switch1.Checked = Switch2.Checked = Switch3.Checked = false;
            Answer5.SelectedItem = "Choose";
            dateTimePicker1.Text = "1. decembra 2012";
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            double percents;
            points = 0;
            wrong = 0;
            //1
            user1 = Answer1.Text.Trim();
            user1.ToLower();
            if (user1.Equals(Answer1Right))
            {
                points++;
            }
            else
            {
                wrong++;
            }
            //2
            if (Answer2R1.Checked == true)
            {
                points++;
            }
            else
            {
                wrong++;
            }
            //3
            if (IP1.Checked == false && IP2.Checked == true && IP3.Checked == true && IP4.Checked == false)
            {
                points++;
            }
            else
            {
                wrong++;
            }
            //4
            if (Switch1.Checked)
            {
                points++;
            }
            else
            {
                wrong++;
            }
            //5
            user5 = Answer5.Text;
            if (user5.Equals(Answer5Right))
            {
                points++;
            }
            else
            {
                wrong++;
            }
            //6
            user6 = dateTimePicker1.Value;
            if (user6.Equals(rightDate))
            {
                points++;
            }
            else
            {
                wrong++;
            }
            percents = ((double)points / ((double)points + (double)wrong)) * 100;
            label7.Text = "Your score: " + points.ToString()+"\nYour points in %: "+percents.ToString();
            label7.Visible = true;
        }
    }
}
